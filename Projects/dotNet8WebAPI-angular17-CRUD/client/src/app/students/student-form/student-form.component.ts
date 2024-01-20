import { JsonPipe } from '@angular/common';
import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { StudentsService } from '../../services/students.service';
import { Subscription } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './student-form.component.html',
  styleUrl: './student-form.component.css'
})
export class StudentFormComponent implements OnInit, OnDestroy {
  form!: FormGroup;
  studentFormSubscription!: Subscription;
  studentService = inject(StudentsService);
  isEdit: boolean = false;
  id!: number;

  constructor(
    private fb: FormBuilder,
    private activateRouter: ActivatedRoute,
    private router: Router,
    private toasterService: ToastrService) { }

  ngOnInit(): void {
    this.activateRouter.paramMap.subscribe((params) => {
      this.studentFormSubscription = this.studentService.getStudentById(Number(params.get('id'))).subscribe((student) => {
        this.form.patchValue(student);
        this.isEdit = true;
      });
    });

    this.form = this.fb.group({
      name: ['',],
      address: [],
      phoneNumber: [],
      email: []
    });
  }

  ngOnDestroy(): void {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.
    this.studentFormSubscription.unsubscribe();
  }

  onSubmit() {
    if (this.isEdit) {
      this.studentService.editStudent(this.id, this.form.value).subscribe((res) => {
        console.log('Student updated successfully!');

        this.toasterService.success('Student updated successfully!');
        this.router.navigateByUrl('/students');
      });
    } else {
      this.studentService.addStudent(this.form.value).subscribe((res) => {
        console.log('Student created successfully!');

        this.toasterService.success('Student created successfully!');
        this.router.navigateByUrl('/students');
      });
    }
  }
}

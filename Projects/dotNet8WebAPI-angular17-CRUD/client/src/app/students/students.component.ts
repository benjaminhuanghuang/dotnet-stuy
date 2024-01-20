import { Component, OnInit, inject } from '@angular/core';
import { StudentsService } from '../services/students.service';
import { Observable } from 'rxjs';
import { Student } from '../types/student';
import { CommonModule } from '@angular/common';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-students',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './students.component.html',
  styleUrl: './students.component.css'
})
export class StudentsComponent implements OnInit {
  studentService = inject(StudentsService);
  toasterService = inject(ToastrService);

  students$!:Observable<Student[]>;

  ngOnInit(): void {
    this.students$ = this.studentService.getStudents();
  }

  delete(id: number) {
    this.studentService.deleteStudent(id).subscribe((res) => {
      this.toasterService.success('Student deleted successfully!');
      this.students$ = this.studentService.getStudents();
    });
  }
}

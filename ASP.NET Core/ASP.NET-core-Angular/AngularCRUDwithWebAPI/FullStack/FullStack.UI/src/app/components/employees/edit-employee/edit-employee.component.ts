import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {
  employeeDetail: Employee = {
    id: '',
    name: '',
    email: '',
    phone: 0,
    salary: 0,
    department: ''
  }
  constructor(private employeeService: EmployeesService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      {
        next: (params) => {
          const id = params.get('id');
          if (id) {
            this.employeeService.getEmployee(id).subscribe({
              next: (employee) => {
                this.employeeDetail = employee;
              }
            });
          }
        }
      }
    )
  }

  updateEmployee() {
    this.employeeService.updateEmployee(this.employeeDetail.id, this.employeeDetail).subscribe({
      next: (employee) => {
        this.router.navigate(['employees']);
      }
    });
  }

  deleteEmployee(id: string) {
    this.employeeService.deleteEmployee(id).subscribe({
      next: (employee) => {
        this.router.navigate(['employees']);
      }
    });
  }


}

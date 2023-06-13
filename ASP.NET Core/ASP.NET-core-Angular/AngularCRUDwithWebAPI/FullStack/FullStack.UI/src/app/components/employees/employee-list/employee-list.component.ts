import { Component, OnInit } from '@angular/core';

import { Employee } from 'src/app/models/employee.model';


@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  employees: Employee[] = [
    {
      id: '5b4ed4cc-f316-444b-a06e-05ce7b322892',
      name: 'John Doe',
      email: 'john.doe@email.com',
      phone: 998877665,
      salary: 60000,
      department: 'Human Resources'
    },
    {
      id: 'c705cd8b-0297-441c-af5b-102620816a70',
      name: 'Sameer Saini',
      email: 'sameer. saini@email.com',
      phone: 789789789,
      salary: 70000,
      department: 'Information Technology'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}

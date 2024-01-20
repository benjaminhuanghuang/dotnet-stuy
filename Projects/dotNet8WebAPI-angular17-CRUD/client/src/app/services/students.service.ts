import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from '../types/student';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  apiUrl = 'http://localhost:5098/api/students/GetAllStudents';

  constructor(private http: HttpClient) { }


  getStudents(): Observable<Student[]> {
    return this.http.get<Student[]>(this.apiUrl);
  }

  addStudent(student: Student) {
    return this.http.post(this.apiUrl, student);
  }

  getStudentById(id: number) {
    return this.http.get<Student>(this.apiUrl + '/' + id);
  }

  editStudent(id: number, student: Student) {
    return this.http.put(this.apiUrl + "/" + id, student);
  }

  deleteStudent(id: number) {
    return this.http.delete(this.apiUrl + '/' + id);
  }
}

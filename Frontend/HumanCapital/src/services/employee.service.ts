import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GetEmployee } from 'src/models/Employee/GetEmployee';
import { CreateEmployee } from 'src/models/Employee/CreateEmployee';


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private baseUrl = 'https://localhost:7171/api/Employees';

  constructor(private http: HttpClient) { }

  getEmployees(): Observable<GetEmployee[]> {
    return this.http.get<GetEmployee[]>(`${this.baseUrl}`)
  }

  getEmployee(id: string): Observable<CreateEmployee> {
    return this.http.get<CreateEmployee>(`${this.baseUrl}/${id}`)
  }

  createEmployee(employee: CreateEmployee): Observable<void> {
    return this.http.post<void>(`${this.baseUrl}`, employee);
  }

  updateEmployee(employee: CreateEmployee): Observable<void> {
    return this.http.put<void>(`${this.baseUrl}`, employee);
  }

  deleteEmployee(id: string): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/${id}`);
  }

}

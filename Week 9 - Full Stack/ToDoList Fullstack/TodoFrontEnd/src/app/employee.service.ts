import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from './employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  url:string = "https://localhost:7008/api/Employees/";
  constructor(private http:HttpClient) { }

  editEmployee:Employee = {} as Employee;

  getAllEmployees():Observable<Employee[]>{
    return this.http.get<Employee[]>(this.url);
  }

  deleteEmployee(id:number):Observable<any> {
    return this.http.delete<any>(this.url+id)
  }

  createEmployee(newEmployee:Employee): Observable<any>{
    return this.http.post<any>(this.url, newEmployee);
  }

  updateEmployee(newValues:Employee, id:number){
    newValues.id = id;
    return this.http.put<any>(this.url+id, newValues)
  }
}

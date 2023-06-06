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

  getAllEmployees():Observable<Employee[]>{
    return this.http.get<Employee[]>(this.url);
  }

  deleteEmployee(id:number):Observable<any> {
    return this.http.delete<any>(this.url+id)
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Student } from './Student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
 
  url:string = "https://localhost:7130/api/Students";
  constructor(private http:HttpClient) { }

  getAllStudents():Observable<any>{
    return this.http.get<Student[]>(this.url);
  }

  createStudent(student:Student):Observable<Student>{
    //Post will take in object and convert into JSON, and then pass that JSON along to the C# API
    //JSON is a format for objects readable by any language
    return this.http.post<Student>(this.url, student);
  }

  deleteStudent(id:number):Observable<any>{
    return this.http.delete<any>(this.url+"/"+id);
  }

  putStudent(id:number, newValues:Student):Observable<any>{
    return this.http.put<any>(this.url+"/"+id, newValues);
  }
}

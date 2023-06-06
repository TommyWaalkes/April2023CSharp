import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ToDo } from './toDo';

@Injectable({
  providedIn: 'root'
})
export class ToDosService {

  url:string ="https://localhost:7008/api/ToDo/";
  constructor(private http:HttpClient) { }

  getAll():Observable<ToDo[]>{
    return this.http.get<ToDo[]>(this.url);
  }

  deleteTodo(id:number){
    return this.http.delete<any>(this.url+id)
  }

  //Remember services can have methods beyond calling APIs
  getToDosByEmployee(employeeId:number, todos:ToDo[] ):any{
    
        let output:ToDo[] = []; 
        for(let i = 0; i < todos.length; i++){
          if(todos[i].assignedTo === employeeId){
            output.push(todos[i]);
          }
        }

        return output;
      }

}

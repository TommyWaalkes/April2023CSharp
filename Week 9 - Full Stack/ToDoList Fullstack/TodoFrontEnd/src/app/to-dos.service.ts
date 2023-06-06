import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ToDo } from './toDo';

@Injectable({
  providedIn: 'root'
})
export class ToDosService {

  url:string ="https://localhost:7008/api/ToDo";
  constructor(private http:HttpClient) { }

  getAll():Observable<ToDo[]>{
    return this.http.get<ToDo[]>(this.url);
  }

  getToDosByEmployee(employeeId:number ):any{
    this.getAll().subscribe(
      (result)=>{
        let output:ToDo[] = []; 
        for(let i = 0; i < result.length; i++){
          if(result[i].assignedTo == employeeId){
            output.push(result[i]);
          }
        }

        return output;
      }
    )
  }

}

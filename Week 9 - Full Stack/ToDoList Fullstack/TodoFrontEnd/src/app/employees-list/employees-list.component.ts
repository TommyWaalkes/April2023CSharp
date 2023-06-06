import { Component } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee';
import { ToDosService } from '../to-dos.service';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent {
  employees:Employee[] = [];
  constructor(private api:EmployeeService, private todoApi:ToDosService){
    this.api.getAllEmployees().subscribe(
      (result) =>{
        this.employees = result;
      }
    );
  }

  //The backend wants to be passed the ID 
  //The front-end will have an easier with the index 
  deleteEmployee(id:number, index:number){
    this.api.deleteEmployee(id).subscribe(
      ()=>{
        this.employees.splice(index,1);
      }
    )
  }

  fillOutTodos(){
    for(let i =0; i < this.employees.length; i++){
      let e  = this.employees[i];
      e.toDos = this.todoApi.getToDosByEmployee(e.id);
    }
  }
}

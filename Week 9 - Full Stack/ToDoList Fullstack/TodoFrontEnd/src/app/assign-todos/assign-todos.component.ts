import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ToDo } from '../toDo';
import { EmployeeService } from '../employee.service';
import { ToDosService } from '../to-dos.service';
import { Employee } from '../employee';

@Component({
  selector: 'app-assign-todos',
  templateUrl: './assign-todos.component.html',
  styleUrls: ['./assign-todos.component.css']
})
export class AssignTodosComponent implements OnInit {

  @Input() todo:ToDo ={} as ToDo;
  @Output() changed = new EventEmitter<ToDo>();
  employees:Employee[] = [];
  selected:Employee = {} as Employee;

  //Constructor runs onces 
  constructor(private employeeApi:EmployeeService, private todoApi:ToDosService){
    
  }

  //Runs every time the component is loaded 
  //You want to use ng on init you are navigating between lots of components
  //It ensures that code will be run
  ngOnInit(): void {
    this.employeeApi.getAllEmployees().subscribe(
      (result)=>{
        this.employees = result;
      }
    );
  }

  assignTodo(employeeId:number){
    //let id = document.getElementById("Assign").selectedIndex; 

    //console.log(id);
    this.todo.assignedTo = employeeId; 
    this.todoApi.updateTodo(this.todo, this.todo.id ).subscribe(
      ()=>{
        this.changed.emit(this.todo);
      }
    )
  }
}

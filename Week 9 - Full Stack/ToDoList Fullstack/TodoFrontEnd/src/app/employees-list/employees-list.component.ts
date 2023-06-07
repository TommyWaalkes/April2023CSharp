import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee';
import { ToDosService } from '../to-dos.service';
import { ToDo } from '../toDo';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {
  employees:Employee[] = [];
  todos:ToDo[] = [];
  display:boolean = false;

  //Runs once as the app loads
  constructor(private employeeApi:EmployeeService, private todoApi:ToDosService){
  
  }

  //Runs any time we reload the component 
  ngOnInit(): void {
    this.loadEmployees();
  }

  loadEmployees(){
    this.employeeApi.getAllEmployees().subscribe(
      (result) =>{
        this.employees = result;
        this.todoApi.getAll().subscribe(
          (result)=>{
            this.todos = result;
            this.fillOutTodos();
          }
        )
      }
    );
  }
  //The backend wants to be passed the ID 
  //The front-end will have an easier with the index 
  deleteEmployee(id:number, index:number){
    console.log(index);
    if(this.employees[index].toDos !== undefined || this.employees[index].toDos.length> 0){
    let toDos: ToDo[] = this.employees[index].toDos; 

      if(toDos.length >0 || this.todos !== undefined){
        for(let i = 0; i < this.todos.length; i++){
          this.todoApi.deleteTodo(toDos[i].id).subscribe(
            ()=>{
              toDos.splice(index, 1);
            }
          );
        }
      }
    }

    this.employeeApi.deleteEmployee(id).subscribe(
      ()=>{
        //this.employees.splice(index,1);
        this.loadEmployees();
      }
    )
  }

  addEmployee(newEmployee:Employee){
    this.employeeApi.createEmployee(newEmployee).subscribe(
      ()=>{
        //this.employees.push(newEmployee);
        this.loadEmployees();
      }
    )
  }

  fillOutTodos(){
    for(let i =0; i < this.employees.length; i++){
      //I pass in the full to do array that way we do not need to call the api every time the loop runs 
      this.employees[i].toDos= this.todoApi.getToDosByEmployee( this.employees[i].id, this.todos);
    }
  }

  selectEmployeeToEdit(e:Employee, index:number){
    this.employeeApi.editEmployee = e;
    this.display = true;
  }
}

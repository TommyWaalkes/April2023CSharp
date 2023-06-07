import { Component, OnInit } from '@angular/core';
import { ToDosService } from '../to-dos.service';
import { ToDo } from '../toDo';
import { Employee } from '../employee';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  todos:ToDo[] =[];
  todoToAssign:ToDo = {} as ToDo; 

  constructor(private todoApi:ToDosService){

  }
  ngOnInit(): void {
    this.loadTodos()
  }

  loadTodos(){
    this.todoApi.getAll().subscribe(
      (result)=>{
        this.todos = result;
        this.todoToAssign = this.todos[0];
      }
    );
  }

  updateAssigned(){
    this.loadTodos();
  }


}

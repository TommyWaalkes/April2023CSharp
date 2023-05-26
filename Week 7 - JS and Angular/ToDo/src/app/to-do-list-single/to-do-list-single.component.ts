import { Component } from '@angular/core';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-to-do-list-single',
  templateUrl: './to-do-list-single.component.html',
  styleUrls: ['./to-do-list-single.component.css']
})
export class ToDoListSingleComponent {
  todos:ToDo[] =[
    {task:"Cheat on taxes", completed: false, isEditing:false}, 
    {task: "Eat Pizza rolls", completed:true, isEditing:false}, 
    {task:"Walk cat", completed:false,isEditing:false }, 
    {task:"Waste paycheck on funko pops", completed:false, isEditing:false}
  ]; 

  newTask:ToDo = {task:"", completed:false, isEditing:false};

  completeTask(index:number):void{
    this.todos[index].completed = true;
  }

  addTask():void{
    this.todos.push(this.newTask); 
    this.newTask =  {task:"", completed:false, isEditing:false};
  }

  deleteTask(index:number){
    this.todos.splice(index, 1);
  }

  editTask(index:number){
    //Turn off editing state for all other items 
    for(let i = 0; i< this.todos.length; i++){
      this.todos[i].isEditing = false; 
    }

    this.todos[index].isEditing =true;
  }

  finishEdit(index:number){
    this.todos[index].isEditing = false; 
  }
}

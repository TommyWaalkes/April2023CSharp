import { Component } from '@angular/core';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-multi-component-list',
  templateUrl: './multi-component-list.component.html',
  styleUrls: ['./multi-component-list.component.css']
})
export class MultiComponentListComponent {
  todos:ToDo[] =[
    {task:"Cheat on taxes", completed: false, isEditing:false}, 
    {task: "Eat Pizza rolls", completed:true, isEditing:false}, 
    {task:"Walk cat", completed:false,isEditing:false }, 
    {task:"Waste paycheck on funko pops", completed:false, isEditing:false}
  ]; 

  newTask(t:ToDo){
    this.todos.push(t);
  }

  deleteTask(index:number){
    this.todos.splice(index, 1);
  }

  updateTask(newValues: ToDo, index:number){
    this.todos[index] = newValues;
  }

  completeTask(index:number){
    this.todos[index].completed = true;
  }
}

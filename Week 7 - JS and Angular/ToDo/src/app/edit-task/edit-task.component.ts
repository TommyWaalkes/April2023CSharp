import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-edit-task',
  templateUrl: './edit-task.component.html',
  styleUrls: ['./edit-task.component.css']
})
export class EditTaskComponent {
  editing:boolean = false;
  //IS like a parameter from a method, but instead its passed to component
  @Input() editTask:ToDo = {task:"", completed: false, isEditing: false}

  //This is like a return statement in a method, but instead we're passing the Todo between and not between methods
  @Output() changed = new EventEmitter<ToDo>();
  finishEditing():void{
    this.editing = false; 
    this.changed.emit(this.editTask);
  }
}

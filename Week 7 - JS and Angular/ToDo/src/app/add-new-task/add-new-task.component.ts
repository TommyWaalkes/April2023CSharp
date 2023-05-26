import { Component, EventEmitter, Output } from '@angular/core';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-add-new-task',
  templateUrl: './add-new-task.component.html',
  styleUrls: ['./add-new-task.component.css']
})
export class AddNewTaskComponent {
  newTask:ToDo = {task:"", completed: false, isEditing:false}
  @Output() changed = new EventEmitter<ToDo>();
  addTask(){
    this.changed.emit(this.newTask);
  }
}

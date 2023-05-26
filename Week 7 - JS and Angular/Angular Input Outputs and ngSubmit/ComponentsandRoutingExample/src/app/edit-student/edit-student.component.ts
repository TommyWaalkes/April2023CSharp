import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.css']
})
export class EditStudentComponent {
  @Input() studentToEdit:Student = {name:"", grade:0}
  @Output() changed = new EventEmitter<Student>();
  editStudent(){
    // this.studentToEdit.name = name; 
    // this.studentToEdit
    this.changed.emit(this.studentToEdit);
  }
}

//name:string, grade:number
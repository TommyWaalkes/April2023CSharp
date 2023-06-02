import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student } from '../Student';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.css']
})
export class EditStudentComponent {
  displayForm:boolean = false;
  @Input() student:Student = {} as Student;
  @Output() changed = new EventEmitter<Student>();

  editStudent(){
    this.changed.emit(this.student);
    this.toggleDisplay();
  }

  toggleDisplay(){
    this.displayForm = !this.displayForm;
  }

}

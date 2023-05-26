import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent {
@Input() student:Student = {name:"", grade:0};
@Output() changed = new EventEmitter<Boolean>();
changeName(student: Student, newValue?: string) {
  if(newValue) {
    student.name = newValue;
    this.changed.emit(true);
  }
}

}

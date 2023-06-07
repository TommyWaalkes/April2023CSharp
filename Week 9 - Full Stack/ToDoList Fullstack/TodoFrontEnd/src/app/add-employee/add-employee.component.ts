import { Component, EventEmitter, Output } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent {
  newEmployee:Employee = {} as Employee;

  @Output() changed = new EventEmitter<Employee>();

  emitEmployee(){
    return this.changed.emit(this.newEmployee);
  }
}

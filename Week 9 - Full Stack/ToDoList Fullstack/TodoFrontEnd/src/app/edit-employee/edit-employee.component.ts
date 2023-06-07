import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {
  employeeToEdit:Employee = {} as Employee;
  display:boolean = false;
  constructor(private apiEmployee:EmployeeService){

  }
  ngOnInit(): void {
    this.loadEmployee();
  }
  loadEmployee(){
    this.employeeToEdit = this.apiEmployee.editEmployee;
  }

  toggleDisplay(){
    this.display = !this.display;
  }

  doneEditing(){
    this.apiEmployee.updateEmployee(this.employeeToEdit, this.employeeToEdit.id).subscribe(
      ()=>{
        this.toggleDisplay();
        this.apiEmployee.editEmployee = this.employeeToEdit;
      }
    );
  }
}

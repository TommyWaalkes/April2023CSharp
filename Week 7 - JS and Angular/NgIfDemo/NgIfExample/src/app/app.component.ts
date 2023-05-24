import { Component } from '@angular/core';
import { Employee } from './employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'NgIfExample';

  employees: Employee[] = [
    {name:"Chimp", age:20, salary:4000, title:"Resident Chimp Expert"}, 
    {name: "Lucius", age:60, salary:10000000, title:"CEO"}, 
    {name: "Janet", age:45, salary:60000, title:"Tax form artist"}
  ];

  showForm:boolean = true;
  newEmployee:Employee = {name:"", age:0, salary:0, title:""};
  employeeToEdit:Employee = {name:"", age:0, salary:0, title:""};
  toggleForm(): void{
    this.showForm = !this.showForm;
  }

  createNewEmployee(): void{
    this.employees.push(this.newEmployee); 

    //Clear out the values in new employee
    this.newEmployee =  {name:"", age:0, salary:0, title:""};
  }

  editEmployee(i:number){
    //Hide other Employees first so only one form appears at a time 
    for(let j = 0; j < this.employees.length; j++){
      this.employees[j].isEditing = false;
    }

    //Seleect the employee to edit 
    //show the edit form for that employee
    this.employeeToEdit = this.employees[i];
    this.employeeToEdit.isEditing = true;
  }

  hideEmployee(i:number):void{
    this.employees[i].isEditing = false;
  }

  deleteEmployee(i:number):void{
    this.employees.splice(i,1);
  }

}

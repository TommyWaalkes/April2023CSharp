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
  toggleForm(): void{
    this.showForm = !this.showForm;
  }

}

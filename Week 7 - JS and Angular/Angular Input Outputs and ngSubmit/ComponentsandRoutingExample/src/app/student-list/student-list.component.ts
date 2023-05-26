import { Component } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent {
  students:Student[] =[
    {name:"Mario", grade:90}, 
    {name:"Luigi", grade:60},
    {name:"Bowser", grade:30}
  ]; 
  updateStudent(s:Student, i:number){
    this.students[i] = s; 
  }
   
  //changeName(name:string, )
}

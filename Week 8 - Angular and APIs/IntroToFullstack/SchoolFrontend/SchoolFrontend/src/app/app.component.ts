import { Component } from '@angular/core';
import { StudentService } from './student.service';
import { Student } from './Student';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SchoolFrontend';
  newStudent:Student = {} as Student;
  students:Student[] =[];
  constructor(private studentService:StudentService){
    this.studentService.getAllStudents().subscribe(
      (result)=>{
        console.log(result);
        this.students = result;
      }
    )
  }

  addNew():void{
    //If you add a new item to your database it will not immediately appear on the front-end 
    //The front-end will have an older version of your student list. 
    //There's a few approaches 
    //1) Simply push the object into the front-end array 
    //2) Say you've edited and changed and add multiple objects in backend, recall the getallstudents method over in our service 
    //And override your array with the updated values
    this.studentService.createStudent(this.newStudent).subscribe(
      (result) =>
      {
      this.students.push(this.newStudent);
      this.newStudent = {} as Student;
      }
    )
  }

  deleteStudent(id:number){
    //Even though this does not return anything, we still need to subscribe to it so it will run
    this.studentService.deleteStudent(id).subscribe(
      ()=>{
        for(let i: number = 0; i < this.students.length; i++){
          let s:Student = this.students[i]; 

          if(s.id === id){
            this.students.splice(i, 1);
            break;
          }
        }
      }
    )
  }

  updateStudent(newValues: Student, i:number){
    this.studentService.putStudent(newValues.id, newValues).subscribe(
      ()=>{
        this.students[i] = newValues;
      }
    ); 
  }


}

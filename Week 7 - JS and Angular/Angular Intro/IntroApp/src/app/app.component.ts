//Imports in JS are like using statements from C# 
//There's a lot that comes with Angular and import statements allow you load in just what you need. 
import { Component } from '@angular/core';

//This dictates a number of setting for this component 
// It'll allow you to pick the component's selector and it's css and HTML files. 
//By default it references files with the matching names to the component
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//This is your App class, this class acts as a controller for the current component 
//When working in angular you will spend a majority of your time working in these classes 
//They fill same role as a .net controller, they decide what data gets pulled in, what gets passed to views, 
//Logic of your app, etc. 

//The big different is that in Angular 1 controller operates on 1 view.
export class AppComponent {
  title = 'IntroApp';
}

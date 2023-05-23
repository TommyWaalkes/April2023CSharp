//Imports in JS are like using statements from C# 
//There's a lot that comes with Angular and import statements allow you load in just what you need. 
import { Component } from '@angular/core';
import { Product } from './product';

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

  //We're inside a class, and properties made in a class do not use the let keyword
  //Local variables in methods still will use the let keyword

  //Anything I make or pull into this class is availiable to the view. 
  greeting:string = "hello world!"; 

  names:string[] = ["Jimmy", "Joey", "Jose", "Jane"];
  products:Product[] = [{name:"Flex Tape", description:"Patches up anything even a broken marriage ", price:35.99}, 
                        {name: "Monopoly Money", description:"Try using this with a vending machine", price:19.99}, 
                        {name: "Rubber Ducky", description: "Goes Squeak", price:4.99}
                      ]
}

import { Component, Input, OnInit } from '@angular/core';
import { MovieDetails, MovieResults, Search } from '../movie';
import { OmdbAPIService } from '../omdb-api.service';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})

//Move the look up by id to app component, this spot should only worry about just displaying movieDetails
export class MovieDetailsComponent  implements OnInit{  
  
  ngOnInit(): void {
    //Why are we using this and how is this different than the constructor? 
    //The constructor is called when the app is first loading and generally only gets called once 
    //On init run every time we look at the component 
   
  }
  //We make an empty JS object the as + type converts into a movie results object 
  //With all of the blank/default values for each property 
  //We use this line with models that are large, complex and have nest properties and arrays 
  //This is so we don't have to manually supply values for these large models 
 @Input() displayMovie:MovieDetails = {} as MovieDetails;


}

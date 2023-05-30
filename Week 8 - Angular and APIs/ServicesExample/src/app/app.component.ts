import { Component } from '@angular/core';
import { PerimeterService } from './perimeter.service';
import { OmdbAPIService } from './omdb-api.service';
import { MovieDetails, Search } from './movie';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ServicesExample';
  len:number = 0; 
  width:number = 0; 
  result:number = 0; 
  searchResults:Search[] = [];
  searchTerm:string ="";
  selectedMovie:MovieDetails = {} as MovieDetails;
  //In any component you may inject as many services as you need 
  constructor(private perimeter:PerimeterService, private omdbAPI: OmdbAPIService){
    
  }

  getRectPerimeter(){
    this.result = this.perimeter.getRectPerimeter(this.len, this.width);
  }

  searchOmdb(){
    this.omdbAPI.searchMovies(this.searchTerm).subscribe(

      //The result of our API call gets dumped into this result object automatically
      //Results type should match the model we made based upon the API  
      (result)=>{
        this.searchResults = result.Search;
      }
    );
  }

  getMovieDetails(id:string){
    this.omdbAPI.searchMoviesById(id).subscribe( (result) =>{
      this.selectedMovie = result;
    })
  }

  selectMovie(m:Search){
    //this.selectedMovie = m;
  }
  

}

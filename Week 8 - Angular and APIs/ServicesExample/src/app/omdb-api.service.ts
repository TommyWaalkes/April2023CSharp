import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieResults } from './movie';

@Injectable({
  providedIn: 'root'
})
export class OmdbAPIService {

  url:string ="https://www.omdbapi.com/?";
  key:string ="62398519";
  //The Http client service gives us access to all the methods we'd nee to call any API
  //There are uses beyond this, but we'll mainly do HTTP calls to call apis
  constructor(private http:HttpClient) { }


  //API calls in Angular are asychronus meaning the call processes in the background as your angular runs 
  //The call can resolve at any time, and we want to be able to react to it. 
  //We'll the observable class to create a listener that waits for the call to be 
  //And then react to its results. Otherwise it keeps running in the background. 
  //
  //In Our services we will return observables set to the type we're trying to pull from our API 
  //In our component, we'll need to subscribe to our observable, which makes the listened mentioned earlier 
  //Which kicks and reacts once the call is done. 
  searchMovies(searchTerm:string):Observable<MovieResults>{
    return this.http.get<MovieResults>(this.url + "s="+searchTerm+"&apikey=" + this.key);
  }

}

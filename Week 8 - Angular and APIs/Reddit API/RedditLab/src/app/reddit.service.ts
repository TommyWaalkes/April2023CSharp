import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RedditPost } from 'src/RedditPost';

@Injectable({
  providedIn: 'root'
})
export class RedditService {
  url:string = "https://www.reddit.com/r/aww/.json"; 
  constructor(private http:HttpClient) { }

  getPosts():Observable<RedditPost>{
    return this.http.get<RedditPost>(this.url);
  }

  getSearch() :Observable<string>{
    return this.http.get<string>("https://www.reddit.com/r/aww/.json");
  }
}

import { Component } from '@angular/core';
import { RedditService } from './reddit.service';
import { Child } from 'src/RedditPost';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'RedditLab';
  posts: Child[] = [];
  permalink: string[] = []; 
  constructor(private redditPosts: RedditService){
    this.redditPosts.getPosts().subscribe(
      (result) => {
        this.posts = result.data.children; 
      }
    )
  }


}

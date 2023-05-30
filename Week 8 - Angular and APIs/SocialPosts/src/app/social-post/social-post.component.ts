import { Component } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-social-post',
  templateUrl: './social-post.component.html',
  styleUrls: ['./social-post.component.css']
})
export class SocialPostComponent {
  posts:Post[] = [
    {thought: "Heres what I ate yesterday:", title:"Food", upVotes:10}, 
    {thought: "This minion meme is fire", title:"Miniions", upVotes:0}, 
    {thought: "Here's my garlic bread recipe", title:"Garlic Bread", upVotes:-10}
  ];

  addNewPost(newPost:Post):void{
    this.posts.push(newPost);
  }

  deletePost(index:number){
    this.posts.splice(index, 1);
  }
}

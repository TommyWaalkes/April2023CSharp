import { Component, EventEmitter, Output } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-new-post-form',
  templateUrl: './new-post-form.component.html',
  styleUrls: ['./new-post-form.component.css']
})
export class NewPostFormComponent {
  newPost: Post ={title:"", thought:"", upVotes:0}; 
  display:Boolean = false;
  @Output() changed = new EventEmitter<Post>(); 

  emitNewPost(){
    this.changed.emit(this.newPost); 
    this.newPost = {title:"", thought:"", upVotes:0};
  }

  toggleDisplay(){
    this.display = !this.display;
  }
}

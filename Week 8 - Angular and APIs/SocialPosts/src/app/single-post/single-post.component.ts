import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-single-post',
  templateUrl: './single-post.component.html',
  styleUrls: ['./single-post.component.css']
})
export class SinglePostComponent {
  @Input() post:Post = {title: "", thought:"", upVotes:0}; 
  @Output() changed = new EventEmitter<Post>();

  upVote():void{
    this.post.upVotes++;
  }

  downVote():void{
    this.post.upVotes--;
  }

  emitDelete(){
    this.changed.emit(this.post);
  }
}

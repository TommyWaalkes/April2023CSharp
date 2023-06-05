import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-double-params',
  templateUrl: './double-params.component.html',
  styleUrls: ['./double-params.component.css']
})
export class DoubleParamsComponent {
  id:number = -1; 
  name:string = "";
  constructor(private route:ActivatedRoute){
    this.id = parseInt(this.route.snapshot.paramMap.get('id')!);

    //This comes angular's version of a session, sessions in general remove typing from anything put them into and converts it into string 
    //Hence why this tends to only be used on single numbers and strings. 
    this.name = this.route.snapshot.paramMap.get('name')!;
  }

}

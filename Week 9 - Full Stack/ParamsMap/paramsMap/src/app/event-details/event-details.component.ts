import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HistoricalEvent } from '../historical-event';

@Component({
  selector: 'app-event-details',
  templateUrl: './event-details.component.html',
  styleUrls: ['./event-details.component.css']
})
export class EventDetailsComponent {

  //We're using this to fake having a db, we will use the id from the paramMap to choose which object we want to view the full details of
  events:HistoricalEvent[] =[
    {id:0, name:"Battle of Tuetonburg Forest", location:"Alemania", year:14},
    {id: 1, name:"Founding of the US", location:"Boston", year:1784 }, 
    {id: 2, name:"French Revolution", location:"France", year:1790 }
  ];
  displayEvent:HistoricalEvent = {} as HistoricalEvent;
  //We want to give this component access to the id passed over to this component
  id:number = -1; 
  constructor(private route:ActivatedRoute){
    this.id = parseInt(this.route.snapshot.paramMap.get('id')!);

    for(let i = 0; i < this.events.length; i++){
      let e:HistoricalEvent = this.events[i];
      if(e.id == this.id){
        this.displayEvent = e;
        break;
      }
    }
  }
}

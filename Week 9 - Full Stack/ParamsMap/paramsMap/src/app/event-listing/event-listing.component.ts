import { Component } from '@angular/core';
import { HistoricalEvent } from '../historical-event';

@Component({
  selector: 'app-event-listing',
  templateUrl: './event-listing.component.html',
  styleUrls: ['./event-listing.component.css']
})
export class EventListingComponent {

  events:HistoricalEvent[] =[
    {id:0, name:"Battle of Tuetonburg Forest", location:"Alemania", year:14},
    {id: 1, name:"Founding of the US", location:"Boston", year:1784 }, 
    {id: 2, name:"French Revolution", location:"France", year:1790 }
  ];
}

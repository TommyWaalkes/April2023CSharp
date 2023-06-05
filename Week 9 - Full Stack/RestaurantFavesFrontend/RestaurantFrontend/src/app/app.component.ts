import { Component } from '@angular/core';
import { OrderService } from './order.service';
import { Order } from './order';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'RestaurantFrontend';

  constructor(private api:OrderService){
    this.api.getOrder(2).subscribe(
      (result)=>{
        console.log(result);
      }
    );
    
  }


}

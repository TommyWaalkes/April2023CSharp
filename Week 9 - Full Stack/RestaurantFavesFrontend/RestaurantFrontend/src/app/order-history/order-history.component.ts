import { Component } from '@angular/core';
import { OrderService } from '../order.service';
import { Order } from '../order';

@Component({
  selector: 'app-order-history',
  templateUrl: './order-history.component.html',
  styleUrls: ['./order-history.component.css']
})
export class OrderHistoryComponent {
  orders:Order[] = [];
  constructor(private api:OrderService){
    this.api.getAllOrders().subscribe(
      (result)=> {this.orders = result}
    );
  }

  deleteOrder(id:number, index:number){
    this.api.delete(id).subscribe(
      (result)=>{
        // for(let i = 0; i < this.orders.length; i++){
        //   let o:Order = this.orders[i];
        //   if(o.id === id){
        //     this.orders.splice(i,1);
        //   }
        // }

        this.orders.splice(index,1);
      }
    );
  }
}

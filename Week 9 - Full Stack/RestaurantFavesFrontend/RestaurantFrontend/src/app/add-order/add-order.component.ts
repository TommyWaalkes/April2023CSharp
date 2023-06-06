import { Component, EventEmitter, Output } from '@angular/core';
import { Order } from '../order';

@Component({
  selector: 'app-add-order',
  templateUrl: './add-order.component.html',
  styleUrls: ['./add-order.component.css']
})
export class AddOrderComponent {
  newOrder: Order = {} as Order;

  @Output() changed: EventEmitter<Order> = new EventEmitter<Order>();

  sendNewOrder(){
    return this.changed.emit(this.newOrder);
  }
}

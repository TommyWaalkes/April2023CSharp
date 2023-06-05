import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from './order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  url:string ="https://localhost:7227/Orders/";
  constructor(private http:HttpClient) { }

  getAllOrders():Observable<Order[]>{
    return this.http.get<Order[]>(this.url);
  }

  getOrder(id:number):Observable<Order>{
    return this.http.get<Order>(this.url+id);
  }

  delete(id:number):Observable<void>{
    return this.http.delete<void>(this.url + id);
  }

  createOrder(newOrder:Order):Observable<void>{
    return this.http.post<void>(this.url, newOrder);
  }
}

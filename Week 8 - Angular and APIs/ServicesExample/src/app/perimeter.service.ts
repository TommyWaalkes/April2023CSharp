import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PerimeterService {

  constructor() { }
  //Angular wants to use methods for your service and not composition
  getRectPerimeter(len:number, width:number):number{
    return 2*len + 2*width;
  }

  getCircumference(radius:number):number{
    return radius * 2 * Math.PI;
  }
}

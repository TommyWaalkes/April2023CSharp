import { Component } from '@angular/core';
import { Address } from './address';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularExcise';

  addresslist:Address[]=[];
  newAddress:Address={name:"",naddress:""};

  addNewAddress(){
    this.addresslist.push(this.newAddress);
    this.newAddress={name:"",naddress:""};
  }

  deleteAddress(i:number){
    this.addresslist.splice(i,1);
  }


}

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

@NgModule({
  //Anytime we make a new component, we'll need to register it with the app by placing it in declarations
  declarations: [
    AppComponent
  ],

  //any extensions to Angular you wish to use will be placed here. 
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventListingComponent } from './event-listing/event-listing.component';
import { RouterModule, Route } from '@angular/router';
import { DoubleParamsComponent } from './double-params/double-params.component';
import { FormsModule } from '@angular/forms';

const routes:Route[] = [
  {path:'', component: EventListingComponent}, 
  {path:'details/:id', component: EventDetailsComponent},
  {path:'doubleParams/:id/:name', component:DoubleParamsComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    EventDetailsComponent,
    EventListingComponent,
    DoubleParamsComponent
    
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

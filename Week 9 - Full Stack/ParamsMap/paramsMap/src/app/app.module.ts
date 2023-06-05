import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventListingComponent } from './event-listing/event-listing.component';
import { RouterModule, Route } from '@angular/router';

const routes:Route[] = [
  {path:'', component: EventListingComponent}, 
  {path:'details/:id', component: EventDetailsComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    EventDetailsComponent,
    EventListingComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

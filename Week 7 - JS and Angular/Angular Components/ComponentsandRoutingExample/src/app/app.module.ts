import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { RouterModule, Route } from '@angular/router';
import { GoodNightMoonComponent } from './good-night-moon/good-night-moon.component';
import { StudentListComponent } from './student-list/student-list.component';

const routes:Route[] =[
  {path:'hello', component: HelloWorldComponent}, 
  {path:'moon', component:GoodNightMoonComponent},
  {path:'studentList', component:StudentListComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HelloWorldComponent,
    GoodNightMoonComponent,
    StudentListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

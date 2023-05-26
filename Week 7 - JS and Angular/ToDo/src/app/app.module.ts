import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ToDoListSingleComponent } from './to-do-list-single/to-do-list-single.component';
import { Route, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { MultiComponentListComponent } from './multi-component-list/multi-component-list.component';
import { AddNewTaskComponent } from './add-new-task/add-new-task.component';
import { EditTaskComponent } from './edit-task/edit-task.component';
const routes:Route[] = [
  {path:"singleList", component:ToDoListSingleComponent},
  {path:"multiList", component:MultiComponentListComponent}
];
@NgModule({
  declarations: [
    AppComponent,
    ToDoListSingleComponent,
    MultiComponentListComponent,
    AddNewTaskComponent,
    EditTaskComponent
  ],
  imports: [
    BrowserModule,
    FormsModule, 
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

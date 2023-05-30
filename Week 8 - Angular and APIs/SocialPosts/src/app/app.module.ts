import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SocialPostComponent } from './social-post/social-post.component';
import { SinglePostComponent } from './single-post/single-post.component';
import { NewPostFormComponent } from './new-post-form/new-post-form.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    SocialPostComponent,
    SinglePostComponent,
    NewPostFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

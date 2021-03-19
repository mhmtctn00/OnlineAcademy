import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainLayoutComponent } from './views/layouts/main-layout/main-layout.component';
import { HomeComponent } from './views/home/home.component';
import { CourseComponent } from './views/course/course.component';
import { CoursesComponent } from './views/courses/courses.component';
import { InstructorLayoutComponent } from './views/layouts/instructor-layout/instructor-layout.component';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent,
    HomeComponent,
    CourseComponent,
    CoursesComponent,
    InstructorLayoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

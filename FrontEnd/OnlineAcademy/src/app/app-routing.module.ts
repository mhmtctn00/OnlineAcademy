import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CourseComponent } from './views/course/course.component';
import { CoursesComponent } from './views/courses/courses.component';
import { HomeComponent } from './views/home/home.component';
import { InstructorLayoutComponent } from './views/layouts/instructor-layout/instructor-layout.component';
import { MainLayoutComponent } from './views/layouts/main-layout/main-layout.component';

const routes: Routes = [
  {
    path: "",
    component: MainLayoutComponent,
    children: [
      {
        path: "",
        component: HomeComponent
      },
      {
        path: "course",
        component: CourseComponent
      },
      {
        path: "courses",
        component: CoursesComponent
      }
    ]
  },
  {
    path: "instructor",
    component: InstructorLayoutComponent,
    children: [

    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

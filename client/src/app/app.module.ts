import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ClinicListComponent } from './hospital/cliniclist.component';
import { HttpClientModule } from '@angular/common/http';
import { DepartmentListComponent } from './department/departmentlist.component';
import { DoctorListComponent } from './doctor/doctorlist.component';
import { NewsListComponent } from './news/newslist.component';
import { DepartmentComponent } from './department/department.component';
import router from './router';
import { DepartmentDetailsComponent } from './department/departmentdetails.component';

@NgModule({
  declarations: [
    AppComponent,
    ClinicListComponent,
    DepartmentListComponent,
    DoctorListComponent,
    NewsListComponent,
    DepartmentComponent,
    DepartmentDetailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    router
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

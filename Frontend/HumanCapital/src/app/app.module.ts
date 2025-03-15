import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeListingComponent } from 'src/components/employee-listing/employee-listing.component';
import { HeaderComponent } from 'src/components/header/header.component';
import { CompanyListingComponent } from 'src/components/company-listing/company-listing.component';
import { EmplyoeeEditorComponent } from 'src/components/emplyoee-editor/emplyoee-editor.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeListingComponent,
    HeaderComponent,
    CompanyListingComponent,
    EmplyoeeEditorComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass: 'toast-top-right', // You can change the position
      timeOut: 3000,
      progressBar: true,
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

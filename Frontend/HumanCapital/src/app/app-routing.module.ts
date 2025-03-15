import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompanyListingComponent } from 'src/components/company-listing/company-listing.component';
import { EmployeeListingComponent } from 'src/components/employee-listing/employee-listing.component';
import { EmplyoeeEditorComponent } from 'src/components/emplyoee-editor/emplyoee-editor.component';

const routes: Routes = [
  { path: "Company", component: CompanyListingComponent },
  { path: "Employee", component: EmployeeListingComponent },
  { path: "Employee/New", component: EmplyoeeEditorComponent },
  { path: "Employee/Edit/:id", component: EmplyoeeEditorComponent },
  { path: '', redirectTo: '/Employee', pathMatch: 'full' },
  { path: '**', redirectTo: '/Employee', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

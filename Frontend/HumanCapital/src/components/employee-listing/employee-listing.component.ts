import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { GetEmployee } from 'src/models/Employee/GetEmployee';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'employee-listing',
  templateUrl: './employee-listing.component.html',
  styleUrls: ['./employee-listing.component.css']
})
export class EmployeeListingComponent implements OnInit {

  employees$: Observable<GetEmployee[]>

  constructor(private employeeService: EmployeeService, private toastr: ToastrService, private router: Router) { }

  ngOnInit() {
    this.employees$ = this.employeeService.getEmployees();
  }

  onEmployeeDeleted(id: string) {
    this.employeeService.deleteEmployee(id).subscribe({
      next: () => {
        this.toastr.success("Deleted Successfully")
        this.employees$ = this.employeeService.getEmployees();
      },
      error: () => this.toastr.error("Error while deleting"),
    });
  }

}

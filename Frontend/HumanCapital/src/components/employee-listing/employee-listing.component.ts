import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { GetEmployee } from 'src/models/Employee/GetEmployee';
import { Observable } from 'rxjs';

@Component({
  selector: 'employee-listing',
  templateUrl: './employee-listing.component.html',
  styleUrls: ['./employee-listing.component.css']
})
export class EmployeeListingComponent implements OnInit {

  employees$: Observable<GetEmployee[]>

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.employees$ = this.employeeService.getEmployees();
  }

}

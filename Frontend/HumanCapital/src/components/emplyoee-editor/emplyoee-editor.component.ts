import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Company } from 'src/models/Company';
import { CreateEmployee } from 'src/models/Employee/CreateEmployee';
import { EmployeeService } from 'src/services/employee.service';
import { CompaniesService } from '../../services/companies.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'emplyoee-editor',
  templateUrl: './emplyoee-editor.component.html',
  styleUrls: ['./emplyoee-editor.component.css']
})
export class EmplyoeeEditorComponent implements OnInit {

  employee: CreateEmployee = new CreateEmployee()
  companies$: Observable<Company[]>
  constructor(
    private employeeService: EmployeeService,
    private companiesService: CompaniesService,
    private route: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.companies$ = this.companiesService.getCompanies()
    if (id) this.getEmployee(id);
  }

  onClearForm() {
    this.employee = new CreateEmployee();
  }

  onSubmit() {
    let request: Observable<void> = new Observable<void>()
    if (this.employee.id)
      request = this.employeeService.updateEmployee(this.employee);
    else
      request = this.employeeService.createEmployee(this.employee)

    request.subscribe({
      next: () => {
        this.toastr.success("Saved Successfully")
        this.router.navigate(["/Employee"])
      },
      error: () => this.toastr.error("Error while saving"),
    });

  }

  getEmployee(id: string) {
    this.employeeService.getEmployee(id).subscribe(employee => {
      Object.assign(this.employee, employee)
      this.employee.companyId = this.employee.company.id
    })
  }
}

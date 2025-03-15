import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Company } from 'src/models/Company';
import { CompaniesService } from 'src/services/companies.service';

@Component({
  selector: 'app-company-listing',
  templateUrl: './company-listing.component.html',
  styleUrls: ['./company-listing.component.css']
})
export class CompanyListingComponent implements OnInit {

  companies$: Observable<Company[]>

  constructor(private companiesService: CompaniesService  ) { }

  ngOnInit() {
    this.companies$ = this.companiesService.getCompanies()

  }

}

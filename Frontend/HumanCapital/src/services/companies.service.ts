import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Company } from 'src/models/Company';

@Injectable({
  providedIn: 'root'
})
export class CompaniesService {
  private baseUrl = 'https://localhost:7171/api/Companies';

  constructor(private http: HttpClient) { }

  getCompanies(): Observable<Company[]> {
    return this.http.get<Company[]>(`${this.baseUrl}`)
  }

}

import { Injectable } from '@angular/core';

@Injectable()
export class CompanyService {
  constructor() {

  }

  getCompanies() {
    return ["Company1", "Company2", "Company3", "Company4",];
  }
}

import { Component } from '@angular/core';
import { CompanyService } from '../services/company.service'

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})

export class CompanyComponent {
  companyName = "Company";
  companies;
  text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sodales eros id accumsan dignissim. Sed ac ultrices purus. Etiam a justo vitae quam tincidunt iaculis. In commodo, ligula a vulputate fermentum, ligula nulla fringilla sem, non fringilla erat ante quis risus. Nunc bibendum, purus at vulputate sodales, augue ipsum posuere.";

  constructor(service: CompanyService) {
    this.companies = service.getCompanies();
  }
}

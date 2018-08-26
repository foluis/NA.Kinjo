import { Component, OnInit } from '@angular/core';
import { User } from '../../models/AppUser';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  private user: User;

  constructor() {

  }

  ngOnInit() {
    this.user = new User({
      email: "",
      password: { pwd: "", confirm_pwd: "" },
    });
  }

  log(x) {
    console.log(x);
  }


}

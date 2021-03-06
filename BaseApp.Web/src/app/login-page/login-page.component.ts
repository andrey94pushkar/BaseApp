import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {
  email = new FormControl('', [Validators.required, Validators.email]);

  getErrorMessage(){
    return this.email.hasError('required') ? 'You must enter a value' :
       this.email.hasError('email') ? 'Not a valid email' :
         '';
  }

  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { SharedService } from '../../core/shared.service';
import { User } from '../../core/models/User';
import { LoginInsertRequest } from 'app/core/models/LoginInsertRequest';

@Component({
  selector: 'app-loginform',
  templateUrl: './loginform.component.html',
  styleUrls: ['./loginform.component.css']
})
export class LoginformComponent implements OnInit {

  model: any = {};
  loggedIn: boolean;
  currentUser$: Observable<User>;

  ngForm: FormGroup;
  data: any;


  constructor(private formBuilder: FormBuilder, private service: SharedService, private route: Router) { }

  ngOnInit(): void {
    if (this.service.isAuthenticated) {
      this.route.navigate(["/categories"]);
    }
    this.initForm();
    // this.currentUser$= this.service.currentUser$; 
  }

  initForm() {
    this.ngForm = this.formBuilder.group({
      username: ["", [Validators.required]],
      password: ["", Validators.required]
    })
  }

  login() {
    if (this.ngForm.valid) {
      let login = new LoginInsertRequest(this.ngForm.get('username').value, this.ngForm.get('password').value);
      this.service.login(login).subscribe(data => {
        localStorage.setItem('token', data.token);
        this.service.isAuthenticated = true;
        this.route.navigate(['/categories']);
      });
      this.ngForm.reset();
    }
  }
  //  login(){
  //    this.service.login(this.model).subscribe(response=>{

  //      this.route.navigate(['/categories']);
  //      this.loggedIn= true;
  //    }, error=>{
  //      console.log(error);
  //    }) 
  //  }  
}

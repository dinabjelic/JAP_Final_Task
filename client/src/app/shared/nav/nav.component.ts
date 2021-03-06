import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutheticationService } from 'app/core/services/authetication.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  loggedIn: boolean;
  
  constructor(public service:AutheticationService, private route:Router) { }

  ngOnInit(): void {
  }
  logout(){
    this.service.logout();
    this.route.navigate(['auth']);
    this.service.isAuthenticated=false;
  }
}

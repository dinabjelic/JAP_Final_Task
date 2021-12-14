import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedService } from '../../core/shared.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  loggedIn: boolean;
  
  constructor(public service:SharedService, private route:Router) { }

  ngOnInit(): void {
  }
  logout(){
    this.service.logout();
    this.route.navigate(['auth']);
    this.service.isAuthenticated=false;
  }
}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'app/core/models/User';
import { Observable } from 'rxjs';
import { SharedService } from '../../core/shared.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  loggedIn: boolean;
  
  constructor(private service:SharedService, private route:Router) { }

  ngOnInit(): void {
  }
  logout(){
    this.service.logout();
    this.route.navigate(['/']);
    this.loggedIn=false; 
  }
}

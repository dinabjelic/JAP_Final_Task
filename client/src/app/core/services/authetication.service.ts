import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, ReplaySubject } from 'rxjs'; //sluzi za asinhrone requests i responses  
import { User } from '../models/User';
import { AuthenticationResult } from 'app/core/models/AuthenticationResult';
import { Router } from '@angular/router';
import { environment } from 'environments/environment';



@Injectable({
  providedIn: 'root'
})
export class AutheticationService {

  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  public isAuthenticated = false;

  constructor(private http: HttpClient, public router: Router) {

    this.isAuthenticated = localStorage.getItem('token') != null
      && localStorage.getItem('token') != undefined && localStorage.getItem('token') != "";
  }

  login(model: any) {
    return this.http.post<AuthenticationResult>(`${environment.apiUrl}`+ "Authentication/login", model);
  }

  logout() {
    localStorage.removeItem('token');
    this.router.navigate(['/auth']);
  }

}

import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { AutheticationService } from "../services/authetication.service";


@Injectable()
export class AuthGuardGuard implements CanActivate {
  constructor(public auth: AutheticationService, public router: Router) { }
  canActivate(): boolean {    
    
    if (!this.auth.isAuthenticated) {
      this.router.navigate(['auth']);
      return false;
    }
    return true;
  }
} 
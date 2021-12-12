import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { SharedService } from "app/core/shared.service";

@Injectable()
export class AuthGuardGuard implements CanActivate {
  constructor(public auth: SharedService, public router: Router) { }
  canActivate(): boolean {    
    
    if (!this.auth.isAuthenticated) {
      this.router.navigate(['auth']);
      return false;
    }
    return true;
  }
} 
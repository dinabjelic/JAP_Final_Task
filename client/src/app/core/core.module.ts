
import { NgModule } from '@angular/core';
import { AppRoutingModule } from 'app/app-routing.module';
import{HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { AuthGuardGuard } from './guards/auth-guard';
import { TokenInterceptorInterceptor } from './interceptor/token-interceptor';



@NgModule({
    declarations: [
    ],
    imports: [
      AppRoutingModule,
      HttpClientModule
    ],
  providers: [
    AuthGuardGuard,{
      provide:HTTP_INTERCEPTORS,
      useClass:TokenInterceptorInterceptor, 
      multi:true
    }
  ],
  })
  export class CoreModule { }
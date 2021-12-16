import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {PaginationModule} from 'ngx-bootstrap/pagination';
import { NgxPaginationModule } from 'ngx-pagination';
import { NavComponent } from './shared/nav/nav.component';
import {ButtonsModule} from 'ngx-bootstrap/buttons';
import {ToastrModule} from 'ngx-toastr';
import {ModalModule} from 'ngx-bootstrap/modal';
import { NgxBootstrapConfirmModule } from 'ngx-bootstrap-confirm';
import { FeaturesModule } from './features/features.module';
import { SharedModule } from './shared/shared.module';
import { CoreModule } from './core/core.module';




@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    Ng2SearchPipeModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatCardModule,
    BrowserAnimationsModule, 
    PaginationModule.forRoot(),
    NgxPaginationModule,
    ButtonsModule.forRoot(),
    ToastrModule.forRoot({
      positionClass: 'toastr-top-left'
    }),
    ModalModule.forRoot(),
    NgxBootstrapConfirmModule,
    FeaturesModule,
    SharedModule,
    CoreModule
  ],
  providers: [
    
  ],
  bootstrap: [AppComponent],
  
  
})
export class AppModule { }

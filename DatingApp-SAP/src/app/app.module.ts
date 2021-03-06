import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';

import {NavComponent} from './nav/nav.component';
import {RegisterComponent} from './register/register.component';
import {HomeComponent} from './home/home.component';
import {ErrorInterceptorProvider} from './_services/error.interceptor';
import {AppComponent} from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    RegisterComponent,
    HomeComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(),
  ],
  providers: [ErrorInterceptorProvider],
  bootstrap: [AppComponent],
})
export class AppModule {}

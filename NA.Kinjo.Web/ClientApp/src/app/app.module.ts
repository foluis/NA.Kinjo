import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ErrorHandler } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

//import { LoginComponent } from './account/login.component';

import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CourseComponent } from './course/course.component';
import { CompanyComponent } from './company/company.component';
import { TestComponent } from './test/test/test.component';
import { PostComponent } from './test/post/post.component';
import { AppErrorHandler } from './Common/app-error-handler';
import { AdminComponent } from './test/admin/admin.component';
import { NoAccessComponent } from './no-access/no-access.component';
import { LoginComponent } from './test/login/login.component';

import { fakeBackendFactory, fakeBackendProvider } from './helpers/fake-backend';
import { MockBackend } from '@angular/http/testing';
import { BaseRequestOptions } from '@angular/http';

//Services

import { CompanyService } from './services/company.service';
import { PostService } from './services/post.service';

import { AuthService } from './services/auth.service';
import { OrderService } from './services/order.service';





//Pipes
import { SummaryPipe } from './pipes/summary.pipe';





@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CourseComponent,
    CompanyComponent,
    TestComponent,
    PostComponent,

    LoginComponent,
    AdminComponent,
    NoAccessComponent,

    //Pipes
    SummaryPipe,
    

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },          
      { path: 'home', component: HomeComponent },      
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'course', component: CourseComponent },
      { path: 'company', component: CompanyComponent },
      { path: 'test', component: TestComponent },
      { path: 'login', component: LoginComponent },
      { path: 'admin', component: AdminComponent },
      { path: 'no-access', component: NoAccessComponent },

    ])
  ],
  providers: [
    CompanyService,
    PostService,
    AuthService,
    OrderService,

    fakeBackendProvider,
    MockBackend,
    BaseRequestOptions,
    
    { provide: ErrorHandler, useClass: AppErrorHandler } // Handles error globaly - replaisment of ErrorHandler with AppErrorHandler class
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

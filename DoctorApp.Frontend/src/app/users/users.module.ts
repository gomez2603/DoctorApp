import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { UserService } from './services/user.service';
import { LoginComponent } from './login/login.component';
import { AngularMaterialModule } from '../angular-material/angular-material.module';
import { RegisterComponent } from './register/register.component';
import { LoginFormComponent } from './login-form/login-form.component';
import { UsersRoutingModule } from './users-routing.module';




@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent,
    LoginFormComponent
  ],
  imports: [
    CommonModule,
    AngularMaterialModule,
    UsersRoutingModule,
    SharedModule
  ],
  exports:[
    LoginComponent
  ],
  providers:[
    UserService
  ]
})
export class UsersModule { }

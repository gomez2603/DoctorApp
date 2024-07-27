import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginFormComponent } from './login-form/login-form.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
    
  {
    path:'', component:LoginComponent, pathMatch:'full',
    children:[
       
        {path:'',component:LoginFormComponent,pathMatch:'full'},
    ] 
  },
  {
    path:'register',component:LoginComponent,pathMatch:'full',
    children:[
        {path:'',component:RegisterComponent,pathMatch:'full'}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})


export class UsersRoutingModule{

}
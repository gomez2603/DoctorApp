import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './shared/layout/layout.component';


const routes: Routes = [
  {
    path:'', 
    loadChildren: () => import('./users/users.module').then(m=> m.UsersModule)
   
  },
  {
    path:'layout',
    component:LayoutComponent,
    pathMatch:'full'
  },
  {
    path:'login', 
    loadChildren: () => import('./users/users.module').then(m=> m.UsersModule)
   
  },
  {
    path:'**', redirectTo: '',pathMatch:'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

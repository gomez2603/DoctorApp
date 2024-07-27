import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule,FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { LayoutComponent } from './layout/layout.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AngularMaterialModule } from '../angular-material/angular-material.module';
import {LayoutModule} from '@angular/cdk/layout';


@NgModule({
  declarations: [
    LayoutComponent,
    DashboardComponent
  ],
  imports: [
    CommonModule,
    AngularMaterialModule

  ],
  exports:[
      ReactiveFormsModule,
      FormsModule,
      HttpClientModule,
      LayoutModule
   
  ]
})
export class SharedModule { }

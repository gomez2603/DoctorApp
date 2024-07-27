import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import  {MatCardModule} from '@angular/material/card'
import {MatInputModule} from '@angular/material/input';
import {matSnackBarAnimations, MatSnackBarModule} from '@angular/material/snack-bar';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button'
@NgModule({
  declarations: [

  ],
  imports: [
    CommonModule
    
  ],
  exports:[
    MatCardModule,
    MatInputModule,
    MatSnackBarModule,
    MatIconModule,
    MatButtonModule
    
  ]
})
export class AngularMaterialModule { }

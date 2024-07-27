import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { SharedService } from 'src/app/shared/services/shared.service';
import { createCompareValidator } from 'src/app/shared/customValidators';
import { ILogin } from '../Interfaces/ILogin';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  formRegister:FormGroup;

  constructor(private fb:FormBuilder,private router:Router, private service:UserService,private sharedservice:SharedService) {
    this.formRegister = this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required],
  
    })
 
  }



  register(){
    
    const request: ILogin = {
      username: this.formRegister.value.username,
      password: this.formRegister.value.password
    }
    this.service.register(request).subscribe({
      next: (response) =>{
        this.sharedservice.saveSession(response)
        this.router.navigate(['layout']);
      },
      complete:()=>{
     
      },
      error: (error) =>{
        console.log(error)
        this.sharedservice.showAlert(error.error,'Close')
      
      }
    })
  }
  
  }


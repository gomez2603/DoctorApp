import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { SharedService } from 'src/app/shared/services/shared.service';
import { ILogin } from '../Interfaces/ILogin';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent {
  formLogin:FormGroup;
  hidepassword:boolean = true
  showloading:boolean = false


  constructor(private fb:FormBuilder,private router:Router, private service:UserService,private sharedservice:SharedService) {
    this.formLogin = this.fb.group({
      username:['',Validators.required],
      password:['',Validators.required]
    })

  }


  login(){
    this.showloading = true
    const request: ILogin = {
      username: this.formLogin.value.username,
      password: this.formLogin.value.password
    }
    this.service.login(request).subscribe({
      next: (response) =>{
        this.sharedservice.saveSession(response)
        this.router.navigate(['layout']);
      },
      complete:()=>{
        this.showloading = false
      },
      error: (error) =>{
        console.log(error)
        this.sharedservice.showAlert(error.error,'Close')
        this.showloading = false
      }
    })
  }
  

}

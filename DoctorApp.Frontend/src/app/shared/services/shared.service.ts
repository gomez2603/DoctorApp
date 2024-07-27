import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ISession } from 'src/app/users/Interfaces/ISession';
@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private _snackBar:MatSnackBar) { }
  showAlert(message:string,type:string){
    this._snackBar.open(message,type)
  }


  saveSession(session:ISession){
    localStorage.setItem("userSession",JSON.stringify(session))
  }


  getSession(){
    const sessionString = localStorage.getItem("userSession");
    const userToken  = JSON.parse(sessionString!)
    return userToken
  }

  removeSession(){
    localStorage.removeItem("userSession")
  }
}

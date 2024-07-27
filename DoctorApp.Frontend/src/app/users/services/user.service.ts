import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { ILogin } from '../Interfaces/ILogin';
import { Observable } from 'rxjs';
import { ISession } from '../Interfaces/ISession';

@Injectable({
  providedIn: 'root'
})
export class UserService {
base_url:string = environment.apiUrl+"Users/"
  constructor(private http:HttpClient) { }


  login(request:ILogin):Observable<ISession>{
    return this.http.post<ISession>(`${this.base_url}login`,request)
  }
  register(request:ILogin):Observable<ISession>{
    return this.http.post<ISession>(`${this.base_url}Register`,request)
  }
}

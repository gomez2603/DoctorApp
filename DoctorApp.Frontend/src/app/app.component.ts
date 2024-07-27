import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'DoctorApp.Frontend';
  usuarios:any
  constructor(private httpclient:HttpClient) {

  }
  ngOnInit(): void {
   this.httpclient.get('http://localhost:5230/api/Users').subscribe({
    next: response => this.usuarios = response,
    error: error => console.log(error.error),
    complete: () => console.log('Solicitud Completa')
   })
  }



}


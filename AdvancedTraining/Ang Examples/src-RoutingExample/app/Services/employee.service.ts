import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../Models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  url : string = "http://localhost:3000/employees"
  constructor(private http : HttpClient) { }

  public getAllEmployees() : Observable<Employee[]>{
    return this.http.get<Employee[]>(this.url) 
  }

  public getEmployee(id : number) : Observable<Employee>{
    let tempUrl = this.url + "/" + id;
    return this.http.get<Employee>(tempUrl);
  }

  public addEmployee(emp : Employee) : Observable<Employee>{
    return this.http.post<Employee>(this.url, emp);
  }

  public deleteEmployee(id : number) : Observable<string>{
    let tempUrl = this.url + "/" + id;
    return this.http.delete<string>(tempUrl); 
  }

  public updateEmployee(emp : Employee) : Observable<Employee>{
    const tempUrl = this.url + "/" + emp.id;
    return this.http.put<Employee>(tempUrl, emp);    
  }
}

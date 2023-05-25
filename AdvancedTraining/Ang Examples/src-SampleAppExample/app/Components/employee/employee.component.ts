import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-employee',
  template: '<h1>Details of {{empObj.name}}</h1><p>{{empObj.address}}</p><p>{{empObj.phone}}</p><p><img src="{{empObj.picture}}"/></p>'
})
export class EmployeeComponent implements OnInit {
  empObj!: Employee;  //The field of the class is refered using this operator in 

  //Use this function to initialize the data of the UR Component
  ngOnInit(): void {
    this.empObj = {
      id : 123,  
      address : "Bangalore", 
      picture : "assets/images/Phaniraj.png",
      name : "Phaniraj", 
      phone : 9945205684
    } 
  }
}

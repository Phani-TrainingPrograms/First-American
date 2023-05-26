import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-emp-mgr',
  templateUrl: './emp-mgr.component.html',
  styleUrls: ['./emp-mgr.component.css']
})
export class EmpMgrComponent implements OnInit { 
  empList : Employee[] = [];
  constructor(private service : EmployeeService) {
    
  }
  ngOnInit(): void {
    this.service.getAllEmployees().subscribe((data: Employee[])=>{
      this.empList = data
    });
  }
}

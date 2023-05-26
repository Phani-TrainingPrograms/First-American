import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Route } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit {
  id : number | null = 0;
  selectedEmp : Employee  = {} as Employee;
  constructor(private service : EmployeeService, private activatedRoute : ActivatedRoute) {
    
  }
  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((paramters : ParamMap)=>{
      this.id = parseInt(paramters.get("id")!);
      this.service.getEmployee(this.id).subscribe((data)=>{
        this.selectedEmp = data;
      })
    })
  }

}

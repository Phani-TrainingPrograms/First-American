import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
//Template driven Forms are the easiest way of creating Validations in Angular Forms. It uses the HTML based validations on the data thru HTML attributes. 
export class TemplateComponent implements OnInit {
  emp : Employee = {} as Employee;
  
  ngOnInit(): void {
    this.emp = {
      empAddress : "", 
      empSalary : "", 
      id : 0, 
      empName : "", 
      empImage : "" 
    }
  }
  //Called only when the validation is completed. 
  onSubmit(empForm : any){
    console.log(empForm.value);
    //Only validating the data of the input form
  }
}

import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-reactive-forms',
  templateUrl: './reactive-forms.component.html',
  styleUrls: ['./reactive-forms.component.css']
})
//Many of the attributes are available that could be set as code behind that will increase the performance of the Validation Scope. It is more Angular centric approach for Validating Angular Forms. 
export class ReactiveFormsComponent {
  emp : Employee = {} as Employee;

  constructor(private service : EmployeeService, private router : Router) {
    
  }
  title : string = "Reactive Forms Validation"
  empForm : FormGroup = new FormGroup({
    id : new FormControl(0, [Validators.required, Validators.min(115), Validators.max(200)]),
    name : new FormControl("", [Validators.required, Validators.minLength(5)]),
    address : new FormControl("", [Validators.required]),
    salary : new FormControl(0, [Validators.required, Validators.min(50000), Validators.max(100000)]),
    image : new FormControl("", [Validators.required])
  })

  get id(){
    return this.empForm.get("id")
  }

  get name(){
    return this.empForm.get("name")
  }

  get salary(){
    return this.empForm.get("salary")
  }

  get address(){
    return this.empForm.get("address")
  }

  get image(){
    return this.empForm.get("image")
  }

  onSubmit(){
    this.emp = {
      id : this.id?.value,
      empName : this.name?.value,
      empAddress : this.address?.value,
      empSalary : this.salary?.value,
      empImage : "assets/images/" + this.image?.value,
    }
    this.service.addEmployee(this.emp).subscribe((data)=>{
      alert("Employee added successfully")
      this.router.navigate(['/'])
    })
  }
}

import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent {
  @Input() selectedEmp : Employee = {} as Employee;
  @Output() onUpdate : EventEmitter<Employee> = new EventEmitter<Employee>(); 
  //Child component for the master component. 
  //master will send the selected Emp as the input to this component
  //Input Directive allows to set property values as input to the components. usually parent component sends inputs to the child components. 
 
  onBtnClicked(){
    alert("Employee updated successfully");
    this.onUpdate.emit(this.selectedEmp);    
  }
  
}

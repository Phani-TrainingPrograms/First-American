import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.css']
})
export class MasterComponent implements OnInit {
  empList : Employee[] = [];
  selectedEmp : Employee = {} as Employee;
  searchByName : string = ""; //variable to hold the searching name

  ngOnInit(): void {
    this.empList.push({ id : 111, name: "Phaniraj", address : "Bangalore", phone : 994520584, picture : "assets/images/Phaniraj.png" });
    this.empList.push({ id : 112, name: "Veeresh", address : "Haveri", phone : 9449184401, picture : "assets/images/veeresh.jpeg" });
    this.empList.push({ id : 113, name: "Faizal", address : "Bangalore", phone : 9845077654, picture : "assets/images/Faizal.jpg" });
    this.empList.push({ id : 114, name: "Harishankar", address : "Kochi", phone : 9944533421, picture : "assets/images/harishankar.jpeg" });
    this.empList.push({ id : 115, name: "Himanshu", address : "Pune", phone : 8899000998, picture : "assets/images/Himanshu.jpg" });
  }

  onSelect(emp : Employee){
    this.selectedEmp = emp;    
  }

  onDataChanged(modified : Employee){
    let index = this.empList.findIndex(e => e.id == modified.id);
    if(index < 0 )
      alert("Not a valid Employee to modify")
    else{
      this.empList.splice(index, 1, modified);
    }
  }
}

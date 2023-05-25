import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  //data
  //functions that can be acting like event handlers to the UI elements
  title = 'sampleapp';
  developer = 'Phaniraj'
  empId : number = 123;
  empName : string = "Phaniraj";
  empAddress : string = "Bangalore";
  imgLoc : string = "assets/images/Phaniraj.png";

  onClick(){
    alert("Messagebox from angular")
  }
}

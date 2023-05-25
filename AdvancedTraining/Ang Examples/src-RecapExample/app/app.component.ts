import { Component } from '@angular/core';

@Component({
  selector: 'app-omkar',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title : string = "Recap Example Demo"
  developedBy : string = "Phaniraj B.N."
  footerText : string = "All Rights Reserved-@CopyRights for FAI Training Team-" + new Date().getFullYear() 
  showMe : boolean = true;
  msg : string = "Hide Me!!!";

  onClickButton(){
    this.showMe = !this.showMe;
    if(this.showMe){
      this.msg = "Hide Me!!!";
    }else{
      this.msg = "Show Me!!!"
    }
  }
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent {
  firstValue: number = 0.0;
  secondValue: number = 0.0;
  operand: string = "Add"
  result = 0.0;

  processCalc() {
    switch (this.operand) {
      case "Add":
        this.result = this.firstValue + this.secondValue;
        break;
      case "Subtract":
        this.result = this.firstValue - this.secondValue;
        break; 
      case "Multiply":
        this.result = this.firstValue * this.secondValue;
        break; 
      case "Divide":
        this.result = this.firstValue / this.secondValue;
        break;
      default:
        break;
    }
  }
}

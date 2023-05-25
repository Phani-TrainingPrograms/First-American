import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { EmployeeComponent } from './Components/employee/employee.component';
import { HeaderComponent } from './Components/header/header.component';
import { CalcComponent } from './Components/calc/calc.component';
import { MasterComponent } from './Components/master/master.component';
import { DetailComponent } from './Components/detail/detail.component';
import { FilterPipe } from './Pipes/filter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    HeaderComponent,
    CalcComponent,
    MasterComponent,
    DetailComponent,
    FilterPipe
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [MasterComponent]
})
export class AppModule { }

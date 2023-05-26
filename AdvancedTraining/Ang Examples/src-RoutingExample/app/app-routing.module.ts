import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { EmpMgrComponent } from './Components/emp-mgr/emp-mgr.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';

const routes: Routes = [
  {path:'', redirectTo: "employees", pathMatch:'full'},
  {path:'employees', component: EmpMgrComponent},
  {path:'employees/view/:id', component: ViewEmpComponent},
  {path:'employees/edit/:id', component: EditEmpComponent},
  {path:'employees/addNew', component: AddEmpComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

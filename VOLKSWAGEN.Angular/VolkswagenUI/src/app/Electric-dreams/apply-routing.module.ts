import { DetailsComponent } from './Vehicle-Details/details/details.component';
import { ApplyComponent } from './apply.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const applyroutes: Routes = [
  {path: '', component: ApplyComponent},
  {path: 'vehicledetails', component: DetailsComponent}
];

@NgModule({
  imports: [RouterModule.forChild(applyroutes)],
  exports: [RouterModule]
})
export class ApplyRoutingModule { }

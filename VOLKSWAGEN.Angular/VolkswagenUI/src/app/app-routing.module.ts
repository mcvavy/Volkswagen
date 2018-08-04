import { DetailsComponent } from './Electric-dreams/Vehicle-Details/details/details.component';
import { ApplyComponent } from './Electric-dreams/apply.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found.component';

const routes: Routes = [{
  path: 'electricdreams',
  component: ApplyComponent
},
{
  path: 'electricdreams/vehicledetails',
  component: DetailsComponent
},
{ path: '',   redirectTo: 'electricdreams', pathMatch: 'full' },
{
  path: '**',
  component: PageNotFoundComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

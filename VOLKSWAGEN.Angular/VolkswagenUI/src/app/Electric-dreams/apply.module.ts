import { DetailsComponent } from './Vehicle-Details/details/details.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApplyRoutingModule } from './apply-routing.module';
import { ApplyComponent } from './apply.component';
import { CrumbComponent } from '../Shared/breadcrumb/crumb/crumb.component';

@NgModule({
  imports: [
    CommonModule,
    ApplyRoutingModule
  ],
  declarations: [ApplyComponent, DetailsComponent, CrumbComponent]
})
export class ApplyModule { }

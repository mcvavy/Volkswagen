import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApplyComponent } from './Electric-dreams/apply.component';
import { PageNotFoundComponent } from './page-not-found.component';
import { SearchComponent } from './Shared/search/search.component';
import { HttpClientModule } from '@angular/common/http';
import { SearchService } from './Shared/service/search.service';
import { DetailsComponent } from './Electric-dreams/Vehicle-Details/details/details.component';
import { CrumbComponent } from './Shared/breadcrumb/crumb/crumb.component';
import { MilageComponent } from './Shared/currentmillage/milage/milage.component';
import { ApplyRoutingModule } from './Electric-dreams/apply-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    ApplyComponent,
    DetailsComponent,
    PageNotFoundComponent,
    SearchComponent,
    CrumbComponent,
    MilageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ApplyRoutingModule
  ],
  providers: [SearchService],
  bootstrap: [AppComponent]
})
export class AppModule { }

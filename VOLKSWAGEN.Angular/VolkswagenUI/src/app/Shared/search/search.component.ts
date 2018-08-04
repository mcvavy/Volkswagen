import { SearchService } from './../service/search.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Response } from './../models/Response';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.styl']
})
export class SearchComponent implements OnInit {
_data;
errorMessage = '';
  constructor(private _searchService: SearchService, private _router: Router) { }
  ngOnInit() {
  }

  getCarDetail(querydata: string) {
    this._router.navigate(['/electricdreams/vehicledetails'], { queryParams: { data : querydata } });
  }

}
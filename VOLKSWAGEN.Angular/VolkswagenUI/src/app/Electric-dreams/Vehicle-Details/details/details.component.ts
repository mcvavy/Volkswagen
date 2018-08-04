import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Response } from '../../../Shared/models/Response';
import { SearchService } from '../../../Shared/service/search.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.styl']
})
export class DetailsComponent implements OnInit {
  errorMsg;
  cardata: Response;
  queryString: string;
  constructor(private route: ActivatedRoute, private router: Router, private _searchService: SearchService) {
  }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.queryString = params['data'];

      this._searchService.getCarRegistration(this.queryString).subscribe((data: Response) => this.cardata = data );
  });
  }

}

import { Response } from './../models/Response';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  constructor(private httpClient: HttpClient) { }

  getCarRegistration(reg: string) {

    return this.httpClient.get(`https://localhost:44330/api/VehicleIdentification/${reg}`);
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class FichaService {

  configUrl = '/api/fichas';

  constructor(private http: HttpClient) { }

  getFichas(){
    return this.http.get(this.configUrl);
  }

}

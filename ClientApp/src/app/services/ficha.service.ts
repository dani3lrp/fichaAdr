import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class FichaService {

  constructor(private http: Http) { }

  getFichas(){
    return this.http.get('/api/fichas')
    .map(res => res.json());
  }

}

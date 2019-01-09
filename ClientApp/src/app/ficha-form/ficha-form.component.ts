import { FichaService } from './../services/ficha.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ficha-form',
  templateUrl: './ficha-form.component.html',
  styleUrls: ['./ficha-form.component.css']
})
export class FichaFormComponent implements OnInit {
  fichas;

  constructor(private fichaService: FichaService) { }

  ngOnInit() {
    this.fichaService.getFichas().subscribe(fichas => {
      this.fichas = fichas
      console.log('FICHAS ', this.fichas)

      });
    
    

  }

}

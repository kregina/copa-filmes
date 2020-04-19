import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { Filme, FilmesService } from '../core/api';

@Component({
  selector: 'copa-filmes-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  $filmes: Observable<Filme[]> = this.filmesService.get();

  selected: number;

  constructor(private filmesService: FilmesService) { }

  ngOnInit(): void {
    this.selected = 3;
  }

}

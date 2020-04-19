import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

import { CampeonatosService, CriarCampeonato, Filme, FilmesService } from '../core/api';

@Component({
  selector: 'copa-filmes-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  $filmes: Observable<Filme[]> = this._filmesService.get();

  selection = new Set<Filme>();

  constructor(
    private _filmesService: FilmesService,
    private _campeonatosService: CampeonatosService,
    private router: Router
  ) { }

  toggleSelection(filme: Filme) {
    this.selection.has(filme)
      ? this.selection.delete(filme)
      : this.selection.add(filme);
  }

  isSelected(filme: Filme) {
    return this.selection.has(filme);
  }

  gerarCampeonato() {
    const payload = <CriarCampeonato>{
      filmes: [...this.selection.values()]
    }

    this._campeonatosService.post(payload)
      .subscribe((response) =>
        this.router.navigate(['./resultado'],
        {state: {data: response}}));

  }

  selecaoValida() {
    return this.selection.size === 8;
  }

}

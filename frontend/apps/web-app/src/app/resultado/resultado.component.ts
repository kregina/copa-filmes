import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Filme } from '../core/api';

@Component({
  selector: 'copa-filmes-resultado',
  templateUrl: './resultado.component.html',
  styleUrls: ['./resultado.component.scss']
})
export class ResultadoComponent implements OnInit {
  resultado: Filme[];

  constructor() { }

  ngOnInit(): void {
    this.resultado = history.state.data;
  }

}

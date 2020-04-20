import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { ResultadoRoutingModule } from './resultado-routing.module';
import { ResultadoComponent } from './resultado.component';


@NgModule({
  declarations: [ResultadoComponent],
  imports: [
    CommonModule,
    ResultadoRoutingModule,
    SharedModule
  ]
})
export class ResultadoModule { }

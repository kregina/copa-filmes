import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatRippleModule } from '@angular/material/core';

import { SelectableCardComponent } from './selectable-card.component';


@NgModule({
  declarations: [SelectableCardComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatCheckboxModule,
    MatRippleModule
  ],
  exports: [
    SelectableCardComponent,
    MatCardModule,
    MatCheckboxModule,
    MatRippleModule
  ]
})
export class SelectableCardModule { }

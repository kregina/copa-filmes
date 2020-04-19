import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatToolbarModule } from '@angular/material/toolbar';
import { SelectableCardModule } from '@copa-filmes/ui-components';

import { HeaderComponent } from './header/header.component';
import { LoadingComponent } from './loading/loading.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [HeaderComponent, LoadingComponent],
  imports: [
    CommonModule,
    MatDividerModule,
    MatProgressSpinnerModule,
    MatToolbarModule,
    MatButtonModule
  ],
  exports: [
    HeaderComponent,
    LoadingComponent,
    MatToolbarModule,
    MatDividerModule,
    SelectableCardModule,
    MatProgressSpinnerModule,
    MatButtonModule,
  ]
})
export class SharedModule { }

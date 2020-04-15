import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { environment } from '../../../environments/environment';

import { API_BASE_URL } from './api';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  providers: [
    {provide: API_BASE_URL, useValue: environment.apiUrl}
  ]
})
export class ApiModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { environment } from '@apps/web-app/environments/environment';
import { API_BASE_URL } from './api';

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: {
    provide: API_BASE_URL,
    useValue: environment.apiUrl
  }
})
export class ApiModule { }

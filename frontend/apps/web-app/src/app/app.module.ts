import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialCssVarsModule } from 'angular-material-css-vars';

import { AppRoutingRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApiModule } from './core/api/api.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialCssVarsModule.forRoot({
      darkThemeClass: 'isDarkTheme'
    }),
    AppRoutingRoutingModule,
    ApiModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}

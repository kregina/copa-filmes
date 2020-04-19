import { Component } from '@angular/core';
import { MaterialCssVarsService } from 'angular-material-css-vars';

@Component({
  selector: 'copa-filmes-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(public materialCssVarsService: MaterialCssVarsService){
    this.materialCssVarsService.setPrimaryColor('#e91e63');
    this.materialCssVarsService.setAccentColor('#4CAF50');
    this.materialCssVarsService.setWarnColor('#f44336');
  }
}

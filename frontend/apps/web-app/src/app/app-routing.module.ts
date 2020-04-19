import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'selecao',
    pathMatch: 'full'
  },
  {
    path: 'selecao',
    loadChildren: () => import('./home/home.module').then(m => m.HomeModule)
  },
  {
    path: 'resultado',
    loadChildren: () => import('./resultado/resultado.module').then(m => m.ResultadoModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    useHash: false,
    anchorScrolling: 'enabled',
    scrollPositionRestoration: 'enabled'
  })],
  exports: [RouterModule]
})
export class AppRoutingRoutingModule { }

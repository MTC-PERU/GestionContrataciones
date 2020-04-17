import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListaPersonalComponent } from './lista-personal/lista-personal.component';
import { TdrComponent } from './tdr/tdr.component';
import { PersonalComponent } from './personal/personal.component';

import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './_helpers';

const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'login', component: LoginComponent },
    { path: 'listaPersonal', component: ListaPersonalComponent},
    { path: 'personal/:id', component: PersonalComponent},
    { path: 'tdr', component: TdrComponent},

    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const appRoutingModule = RouterModule.forRoot(routes);
/*
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
*/
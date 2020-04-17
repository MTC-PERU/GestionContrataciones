import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

// used to create fake backend
import { fakeBackendProvider } from './_helpers';

import { AppComponent } from './app.component';

import { JwtInterceptor, ErrorInterceptor } from './_helpers';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { PersonalComponent } from './personal/personal.component';
import { TdrComponent } from './tdr/tdr.component';
import { appRoutingModule } from './app-routing.module';
import { ListaPersonalComponent } from './lista-personal/lista-personal.component';



@NgModule({
    imports: [
        BrowserModule,
        ReactiveFormsModule,
        HttpClientModule,
        appRoutingModule,
        FormsModule,
        ReactiveFormsModule,
    ],
    declarations: [
        AppComponent,
        HomeComponent,
        LoginComponent,
        PersonalComponent,
        TdrComponent,
        ListaPersonalComponent,
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },

        // provider used to create fake backend
        fakeBackendProvider
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from './_services';
import { User } from './_models';
declare const cargarmenu: any;

@Component({ selector: 'app', templateUrl: 'app.component.html' })
export class AppComponent {
    currentUser: User;
    loggedUser: boolean;

    constructor(
        private router: Router,
        private authenticationService: AuthenticationService
    ) {
        this.loggedUser = false;
        this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
    }

    ngAfterViewChecked()
    {
        if(this.currentUser && !this.loggedUser){
            this.loggedUser = true;
            cargarmenu();
        }
    }

    logout() {
        this.loggedUser = false;
        this.authenticationService.logout();
        this.router.navigate(['/login']);
    }
}
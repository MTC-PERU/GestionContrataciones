import { Component, OnInit } from '@angular/core';
import { PersonalService } from '../_services/personal.service';
import { PersonalModel } from '../_models/PersonalModel';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-lista-personal',
  templateUrl: './lista-personal.component.html',
  styleUrls: ['./lista-personal.component.less']
})
export class ListaPersonalComponent implements OnInit {
  tablaPersonas: any ={};
  cargando = false;

  constructor( private PersonalService: PersonalService) { }
  
  

  ngOnInit() {
    this.cargando = true;

    this.PersonalService.getPersonal()
        .subscribe( resp => {
            this.tablaPersonas = resp;
            this.cargando = false; 
        });
  }

  borrarPersonal( persona: PersonalModel, i: number){
    console.log(i);
     
    Swal.fire({
      title:  '¿Está seguro?',
      text: `Está seguro que desea borrar a ${ persona.nombres}, ${ persona.apellido_Paterno} ${ persona.apellido_Materno} `,
      icon: 'question',
      showConfirmButton: true,
      showCancelButton: true
    }).then( resp => {
        if ( resp.value ){
            //this.tablaPersonas.splice(i,1);
            this.PersonalService.borrarPersona(persona.personalId).subscribe();
        }
    });

      

      // this.PersonalService.getPersonal()
      //   .subscribe( resp => {
      //       this.tablaPersonas = resp;
      //   });

  }
}

import { Component, OnInit } from '@angular/core';
import { PersonalService } from '../_services/personal.service';
import { PersonalModel } from '../_models/PersonalModel';
import { FormBuilder, FormGroup, Validators, NgForm } from '@angular/forms';
import Swal from 'sweetalert2';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-personal',
  templateUrl: './personal.component.html',
  styleUrls: ['./personal.component.less']
})
export class PersonalComponent implements OnInit {

  personal = new PersonalModel

  form: FormGroup;

  constructor(private personalService: PersonalService, 
              private fb: FormBuilder, 
              private route: ActivatedRoute) { 
    

  }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    
    if (id !== 'nuevo'){
      this.personalService.getPersona( id)
          .subscribe( (resp: PersonalModel) => {
            this.personal = resp;
            console.log(resp);
          });
    }
  }

  guardar( form: NgForm){

      if( form.invalid ){
        console.log('formulario no valido');
        return;
      }

      Swal.fire({
        title: 'Espere',
        text: 'Guardando información',
        icon: 'info',
        allowOutsideClick: false
      })

      Swal.showLoading(); 

      let peticion: Observable<any>;

       if ( this.personal.personalId ){
              peticion = this.personalService.actualizarPersonal( this.personal );
       }else{
              peticion = this.personalService.crearPersonal( this.personal );
       }

      peticion.subscribe( resp => {
          Swal.fire({
            title: this.personal.nombres + ' , ' + this.personal.apellido_Paterno, 
            text: 'Se actualizo correctamente',
            icon: 'success'
            
          });
      });

     
  }


  onSubmit(formValue: any){

  }

}

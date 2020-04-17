export class PersonalModel {
    personalId:string;
    nombres: string;
    apellido_Paterno  : string;
    apellido_Materno : string;
    direccion: string;
    perfil: string;
    experiencia_General: string;
    experiencia_Especifica: string;
    esCoordinador: boolean;
    dni: string;
    ruc: string;
    email: string; 
    cci: string;
    nro_Celular : string;

    constructor(){
        this.esCoordinador = false;
    }
}
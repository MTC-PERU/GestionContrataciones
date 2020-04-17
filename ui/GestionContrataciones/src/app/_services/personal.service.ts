import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonalModel } from '../_models/PersonalModel';
import { map, delay } from 'rxjs/operators';
import { CollectionItemsModel } from '@app/_models/CollectionItemsModel';



@Injectable({
  providedIn: 'root'
})
export class PersonalService {

  private url = 'http://localhost:63572';
    

  constructor(private http: HttpClient) { }

  crearPersonal( personal: PersonalModel){
  
    return this.http.post(`${ this.url }/Personal`, personal )
                    .pipe(
                      map( (resp: any) => {
                            personal.personalId = resp.personalId;
                            return personal;
                      })
                    );
  }

  actualizarPersonal ( personal: PersonalModel){

    const personalTemp = {
      ...personal
    };

    delete personalTemp.personalId;

    return this.http.put (`${ this.url }/personal/${personal.personalId}`, personalTemp);

  }

  getPersonal(){

    return this.http.get(`${ this.url }/personal?page=1&take=10`);
   
  }

  getPersona( id: string ){
    return this.http.get(`${ this.url}/personal/${ id }`);
  }
  borrarPersona( id: string ){
      return this.http.delete(`${ this.url}/personal/${ id }`);
  }
}

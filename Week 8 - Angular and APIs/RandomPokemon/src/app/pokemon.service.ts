import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pokemon } from './pokemon';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PokemonService {

  url:string ="https://pokeapi.co/api/v2/pokemon/";
  constructor(private http:HttpClient) { }

  getPokemonById(id:number):Observable<Pokemon>{
    return this.http.get<Pokemon>(this.url + id);
  }
}

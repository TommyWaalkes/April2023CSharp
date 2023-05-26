import { Component } from '@angular/core';
import { Pokemon } from '../pokemon';

@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.css']
})
export class PokemonListComponent {
  pokemon:Pokemon[] =[
    {id:25, name:"Pikachu", evolveLevel:-1, types:["Electric"]}, 
    {id:129, name:"Magicarp", evolveLevel:20, types:["Water"]}, 
    {id:140, name:"Chancey", evolveLevel:-1, types:["Normal"]}, 
    {id:9, name:"Charizard", evolveLevel:-1, types:["Fire", "Flying"]}, 
  ];

  addPokemon( p:Pokemon):void{
    this.pokemon.push(p);
  }
}

import { Component, EventEmitter, Output } from '@angular/core';
import { Pokemon } from '../pokemon';

@Component({
  selector: 'app-add-new-pokemon',
  templateUrl: './add-new-pokemon.component.html',
  styleUrls: ['./add-new-pokemon.component.css']
})
export class AddNewPokemonComponent {
  newPokemon:Pokemon = {id:0, name:"", evolveLevel:0, types:[]}; 
  @Output() changed = new EventEmitter<Pokemon>();
  types:string = "";

  addNew():void{
    this.newPokemon.types = this.types.split(","); 
    this.changed.emit(this.newPokemon); 
    //Clear out our form, by setting the new object back to being blank
    this.newPokemon = {id:0, name:"", evolveLevel:0, types:[]}; 
  }
}


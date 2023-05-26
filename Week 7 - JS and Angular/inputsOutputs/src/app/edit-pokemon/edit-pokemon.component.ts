import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Pokemon } from '../pokemon';

@Component({
  selector: 'app-edit-pokemon',
  templateUrl: './edit-pokemon.component.html',
  styleUrls: ['./edit-pokemon.component.css']
})
export class EditPokemonComponent implements OnInit {

  show:boolean = false;
  @Input() editPokemon:Pokemon = {id:0, name:"", evolveLevel:0, types:[]};
  types:string ="";
  @Output() changed = new EventEmitter<Pokemon>();
  ngOnInit(){
    console.log(this.editPokemon);
    for(let i = 0; i<this.editPokemon.types.length; i++){
      if(i<this.editPokemon.types.length -1){
        this.types += this.editPokemon.types[i] + ",";

      }
      else{
        this.types += this.editPokemon.types[i];
      }
    }
  }

  sendUpEdits(){
    this.show = !this.show;
    this.editPokemon.types = this.types.split(",");
    this.changed.emit(this.editPokemon); 
  }
}

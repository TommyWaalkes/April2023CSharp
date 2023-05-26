import { Component, Input } from '@angular/core';
import { Pokemon } from '../pokemon';

@Component({
  selector: 'app-pokemon-details',
  templateUrl: './pokemon-details.component.html',
  styleUrls: ['./pokemon-details.component.css']
})
export class PokemonDetailsComponent {

  @Input() pokemon:Pokemon = {id:0, name:"", evolveLevel:0, types:[]}; 
}

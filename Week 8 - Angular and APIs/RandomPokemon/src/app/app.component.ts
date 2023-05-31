import { Component } from '@angular/core';
import { PokemonService } from './pokemon.service';
import { RandomNumberGeneratorService } from './random-number-generator.service';
import { Pokemon } from './pokemon';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'RandomPokemon';
  displayPokemon: Pokemon = {} as Pokemon;
  constructor(private pokemonApi: PokemonService, private random:RandomNumberGeneratorService){
    this.getRandomPokemon();
  }

  getRandomPokemon():void{
    let num:number = this.random.generateRandomNumber(1,1000);
    this.pokemonApi.getPokemonById(num).subscribe(
      (result) => {
        this.displayPokemon = result;
      }
    )
  }

}

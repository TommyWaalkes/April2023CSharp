using RestSharp;

namespace RandomPokemon.Models
{
    public class PokemonDAL
    {

        public Pokemon GetRandomPokemon()
        {
            Random r = new Random();
            int pokeId = r.Next(1, 1011);
            RestClient rc = new RestClient($"https://pokeapi.co/api/v2/pokemon-form/{1010}");
            RestRequest rr = new RestRequest();

            Task<Pokemon> response = rc.GetAsync<Pokemon>(rr);
            Pokemon poke = response.Result;

            return poke;


        }
    }
}

using RestSharp;

namespace DeckOfCardsWar.Models
{
    public class DeckDAL
    {
        public Deck GetDeck()
        {
            RestClient client = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            RestRequest request = new RestRequest();
            Task<Deck> response = client.GetAsync<Deck>(request);
            Deck d = response.Result;

            return d;
        }

        public List<PlayerDeck> GetPlayerDecks(string deckId)
        {
            RestClient client = new RestClient($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=26");
            RestRequest request = new RestRequest();
            Task<PlayerDeck> response = client.GetAsync<PlayerDeck>(request);
            PlayerDeck player1 = response.Result;

            RestClient client2 = new RestClient($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=26");
            RestRequest request2 = new RestRequest();
            Task<PlayerDeck> response2 = client2.GetAsync<PlayerDeck>(request2);
            PlayerDeck player2 = response2.Result;

            List<PlayerDeck> decks= new List<PlayerDeck>();
            decks.Add(player1);
            decks.Add(player2);

            return decks;
        }
    }
}

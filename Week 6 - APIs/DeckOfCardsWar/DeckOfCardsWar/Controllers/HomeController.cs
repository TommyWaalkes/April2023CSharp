using DeckOfCardsWar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsWar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DeckDAL cardAPI = new DeckDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Deck d = cardAPI.GetDeck();
            List<PlayerDeck> players = cardAPI.GetPlayerDecks(d.deck_id);


            return View(players);
        }

        public IActionResult FindWinner(List<PlayerDeck> players)
        {
            Card[] player1Cards = players[0].cards;
            Card[] player2Cards = players[1].cards;
            Card c1 = player1Cards[0];
            Card c2 = player2Cards[0];

            //Higher index in this array means that player wins
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "JACK", "QUEEN", "KING", "ACE" };

            int pos1 = -1; 
            int pos2 = -1;

            for(int i = 0; i < values.Length; i++)
            {
                string v = values[i];
                if(c1.value == v)
                {
                    pos1 = i;
                }
                if(c2.value == v)
                {
                    pos2 = i;
                }
            }

            if(pos1 > pos2)
            {
                //Remove the card from the loser's deck 
                //Add it to the winner's deck. 
                List<Card> cards = player1Cards.ToList();
                cards.Add(c2);
                players[0].cards = cards.ToArray();

                List<Card> p2Cards = player2Cards.ToList();
                p2Cards.Remove(c2);
                players[1].cards = p2Cards.ToArray();
            }
            else if(pos1< pos2)
            {
                //Remove the card from the loser's deck 
                //Add it to the winner's deck. 
                List<Card> cards = player2Cards.ToList();
                cards.Add(c1);
                players[1].cards = cards.ToArray();

                List<Card> p1Cards = player1Cards.ToList();
                p1Cards.Remove(c2);
                players[0].cards = p1Cards.ToArray();
            }

            TempData["Decks"] = players;

            return View(players);
        }
    }
}

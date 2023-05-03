using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo
{
    public class MovieController
    {
        //We are not connected to a database 
        //This property is here to fake that
        public List<Movie> MovieDB { get; set; } = new List<Movie>();
        public MovieController()
        {
            MovieDB.Add(new Movie("Shrek", 90, Rating.PG13));
            MovieDB.Add(new Movie("Cars", 100, Rating.G));
            MovieDB.Add(new Movie("The Big Lebowski", 120, Rating.R));
        }

        //In a controller methods that manage a view are often called actions. 
        //Each view will get its own action 
        //If needed you may still write regular methods 
        public void Home()
        {
            HomeView hv = new HomeView();
            string res = hv.Display();

            if(res == "y")
            {
                //Redirect to our listing page. 
                Listing();
            }
        }

        public void Listing()
        {
            MovieListView mlv = new MovieListView(MovieDB);
            Movie selected = mlv.Display();

            MovieDetails(selected);
        }

        public void MovieDetails(Movie movie)
        {
            DetailsView dv = new DetailsView(movie);
            dv.Display();

            Console.WriteLine("Would you like to look at another movie? y/n");
            string response = Console.ReadLine();

            if(response == "y")
            {
                Listing();
            }
            else
            {
                Console.WriteLine("Okay good bye!");
            }
        }

    }
}

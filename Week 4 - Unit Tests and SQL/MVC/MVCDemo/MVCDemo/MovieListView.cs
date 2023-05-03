using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo
{
    public class MovieListView
    {
        public List<Movie> displayMovies;

        //This view in order to function requires a list of movies 
        //The nice thing about views is that they don't care where the movie list comes so this view will work on anything 
        //That is a valid list of movie object.
        public MovieListView(List<Movie> displayMovies)
        {
            this.displayMovies = displayMovies;
        }

        public Movie Display()
        {
            for(int i = 0; i < displayMovies.Count; i++)
            {
                Console.WriteLine(i + " " + displayMovies[i].Title);
            }
            Console.WriteLine("Select a movie you want to see the full details for by index");
            int pick = int.Parse(Console.ReadLine());

            return displayMovies[pick];
        }
    }
}

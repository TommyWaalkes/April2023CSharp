using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster() {
            Movies.Add(new DVD("Shrek", 90, Genre.Comedy, "Shrek enjoying swamp", "Donkey shows up", "They go to the castle"));
            Movies.Add(new DVD("Terminator", 110, Genre.Action, "Give me your clothes", "Tech Noir", "Highway Chase"));
            Movies.Add(new VHS("Lord of the Rings", 200, Genre.Drama, "Bilbo find the ring", "They fight Sauron", "The Shire"));
        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine(i + " " + m.Title);
            }
        }

        public Movie Checkout()
        {
            PrintMovies();

            int index = Validator.GetIntFromUser("Which movie would you like to watch?");
            bool validIndex = Validator.WithinRange(index, Movies);

            if (validIndex)
            {
                Movie m = Movies[index];
                return m;
            }
            else
            {
                Console.WriteLine("That was not index please input something 0 to " + (Movies.Count-1));
                Console.WriteLine("Let's try again");
                return Checkout();
            }
        }
    }
}

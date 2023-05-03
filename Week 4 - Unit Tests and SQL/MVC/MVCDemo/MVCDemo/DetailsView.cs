using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo
{
    public class DetailsView
    {
        public Movie DisplayMovie; 

        //This is the views way of saying I must get a movie for this view to work. 
        public DetailsView(Movie displayMovie)
        {
            DisplayMovie = displayMovie;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + DisplayMovie.Title);
            Console.WriteLine("Run Time: "+ DisplayMovie.RunTime);
            Console.WriteLine("Rating: " + DisplayMovie.Rating);
        }
    }
}

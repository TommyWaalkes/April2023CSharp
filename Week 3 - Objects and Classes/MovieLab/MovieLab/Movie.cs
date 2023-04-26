using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    class Movie
    {
        public string Title { get; set; }
        public MovieGenre Category { get; set; }

        public Movie(string Title, MovieGenre Category)
        {
            this.Title = Title;
            this.Category = Category;
        }


    }

    //What is an enum? An enum is a way of creating a type without making a class. 
    //Enums ensure that they get only a preset series of values. Enums are more restrictive than a string. 
    //If parameter is of a string data type I can input any value \

    //Enums are useful when you want only take in certain values
    public enum MovieGenre
    {
        invalid,
        horror, 
        comedy, 
        drama, 
        scifi, 
        animated
    }
}

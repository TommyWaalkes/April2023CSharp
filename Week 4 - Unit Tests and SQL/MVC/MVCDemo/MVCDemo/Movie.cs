using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo
{
    public enum Rating
    {
        G,
        PG,
        PG13,
        R,
        NC17,
        UNRATED
    }
    public class Movie
    {
        //Models generally are going to be a series of properties 
        //And sometimes functionality based on converting data or pulling it. 
        public string Title { get; set; }
        public int RunTime { get; set; }
        public Rating Rating { get; set; }

        public Movie(string title, int runTime, Rating rating)
        {
            Title = title;
            RunTime = runTime;
            Rating = rating;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using OmdbScrapper.Models;

namespace OmdbScrapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController: ControllerBase
    {
        MovieDAL api = new MovieDAL();
        MovieContext db = new MovieContext();

        //This method will be good for initially filling up a database 
        //Pass it around to each person in your project so everyone can start out with the same set of data
        [HttpGet("fill")]
        public void FillInDB()
        {
            List<string> movieTitles = new List<string>()
            {
                //"Shrek",
                "Alien",
                "Ghost", 
                "Star Wars", 
                "Billy Madison", 
                "The Big Lebowski"
            };

            for (int i = 0; i < movieTitles.Count; i++)
            {
                MovieDetails md = api.GetMovieDetails(movieTitles[i]);
                db.MovieDetails.Add(md);
            }

            db.SaveChanges();
        }


        //Use this if uyou want to add movies as you think of them and have gotten in the intial movies
        [HttpGet("title={title}")]
        public void AddMovie(string title)
        {
            MovieDetails md = api.GetMovieDetails(title);
            db.MovieDetails.Add(md);
            db.SaveChanges();

        }
    }
}

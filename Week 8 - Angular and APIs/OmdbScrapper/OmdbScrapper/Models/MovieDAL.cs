using RestSharp;

namespace OmdbScrapper.Models
{
    public class MovieDAL
    {
        string baseUrl = "https://www.omdbapi.com/";
        string apiKey = "&apikey=62398519";

        public MovieDetails GetMovieDetails(string title)
        {
            string fullUrl = baseUrl + "?t=" + title + apiKey;
            RestClient client = new RestClient(fullUrl);
            RestRequest request = new RestRequest();
            Task<MovieDetails> response = client.GetAsync<MovieDetails>(request);

            return response.Result;
        }
    }
}

using RestSharp;

namespace WebApplication2
{
    public class DAL
    {
        public string getResult()
        {
            string url = @"https://api.spoonacular.com/recipes/716429/information?apiKey=2b51e14cd91748669ab2027295a55f00&includeNutrition=true";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            var response = client.GetAsync<string>(request);
            string sp = response.Result;
            return sp; 

        }
    }
}

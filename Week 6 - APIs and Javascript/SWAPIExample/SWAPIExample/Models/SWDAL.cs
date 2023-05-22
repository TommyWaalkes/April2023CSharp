using RestSharp;

namespace SWAPIExample.Models
{
    //Technically API calls can be done anywhere you can use C# 
    //However, I prefer to put API calls in a DAL and not a model or controller 
    //The reason is that I can reuse the DAL class anywhere and get consistent behavior 
    //If I find a bug with my API call, I only need to fix it in the DAL 
    public class SWDAL
    {
        public SWPerson GetPerson(int id)
        {
            RestClient client = new RestClient($"https://swapi.dev/api/people/{id}/");
            RestRequest request = new RestRequest();

            //This will give you a object with a SWPerson nested inside 
            //This grabs the result of the API call from the API server 
            //and once the call is done running, store the response, which has the result in the response object
            SWPerson response = client.Get<SWPerson>(request);

            return response;
        }
    }
}

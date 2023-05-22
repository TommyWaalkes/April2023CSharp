using Microsoft.Extensions.Options;
using RestSharp;
using static System.Net.WebRequestMethods;

namespace SWAPIExample.Models
{
    //Technically API calls can be done anywhere you can use C# 
    //However, I prefer to put API calls in a DAL and not a model or controller 
    //The reason is that I can reuse the DAL class anywhere and get consistent behavior 
    //If I find a bug with my API call, I only need to fix it in the DAL 
    public class DonutDAL
    {
        public SWPerson GetPerson(int id)
        {
            string url = "https://swapi.dev/api/people/{id}/";
            var options = new RestClientOptions(url)
            {
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
             };
            RestClient client = new RestClient(options);
            RestRequest request = new RestRequest();

            //This will give you a object with a SWPerson nested inside 
            //This grabs the result of the API call from the API server 
            //and once the call is done running, store the response, which has the result in the response object
            SWPerson response = client.Get<SWPerson>(request);

            return response;
        }

        public DonutResults GetDonuts()
        {
            string URL = "https://grandcircusco.github.io/demo-apis/donuts.json";
            RestClient client = new RestClient(URL);
            RestRequest request = new RestRequest();

            DonutResults response = client.Get<DonutResults>(request);

            return response;
        }

        public DonutDetails GetDonutDetails(int id)
        {
            string url = $"https://grandcircusco.github.io/demo-apis/donuts/{id}.json";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();

            DonutDetails response = client.Get<DonutDetails>(request);

            return response;
        }
    }
}

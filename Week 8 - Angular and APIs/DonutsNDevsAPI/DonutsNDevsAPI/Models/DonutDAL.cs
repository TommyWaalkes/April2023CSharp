using RestSharp;

namespace DonutsNDevsAPI.Models
{
    public class DonutDAL
    {
        string baseUrl = "https://grandcircusco.github.io/demo-apis/donuts";

        public DonutSearchResult GetDonutResults()
        {
            RestClient client = new RestClient($"{baseUrl}.json");
            RestRequest request = new RestRequest();
            Task<DonutSearchResult> response = client.GetAsync<DonutSearchResult>(request);

            return response.Result;
        }

        public DonutDetails GetDonutDetails(int id)
        {
            RestClient client = new RestClient($"{baseUrl}/{id}.json");
            RestRequest request = new RestRequest();
            Task<DonutDetails> response = client.GetAsync<DonutDetails>(request);
            return response.Result;
        }
    }
}

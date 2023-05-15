using RestSharp;

namespace SWAPIExample.Models
{
    public class SWDAL
    {
        public SWPerson GetPerson(int id)
        {
            RestClient client = new RestClient($"https://swapi.dev/api/people/{id}/");
            RestRequest request = new RestRequest();
            Task<SWPerson> response = client.GetAsync<SWPerson>(request);
        }
    }
}

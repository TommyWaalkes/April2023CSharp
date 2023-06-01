using DonutsNDevsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DonutsNDevsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonutController : ControllerBase
    {
        DonutDAL dal = new DonutDAL();
        [HttpGet]
        public DonutSearchResult GetDonuts()
        {
            return dal.GetDonutResults();
        }

        [HttpGet("{id}")]
        public DonutDetails GetDetails(int id)
        {
            return dal.GetDonutDetails(id);
        }
    }
}

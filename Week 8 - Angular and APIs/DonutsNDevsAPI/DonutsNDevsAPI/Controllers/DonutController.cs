using DonutsNDevsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DonutsNDevsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonutController : ControllerBase
    {
        DonutDAL dal = new DonutDAL();
        DonutContext db = new DonutContext();

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

        [HttpGet("fillDb")]
        public void FillInDB()
        {
            //DonutSearchResult dr = dal.GetDonutResults();
            //foreach(Result r in dr.results)
            //{
            //    r.id = 0; 
            //    db.donutResults.Add(r);
            //}
            List<DonutDetails> details = new List<DonutDetails>();
            List<Extra> extras = new List<Extra>();
            for(int i = 0; i < 9; i++)
            {
                DonutDetails d = dal.GetDonutDetails(i);
                details.Add(d);
                foreach(Extra e in d.extras)
                {
                    extras.Add(e);
                }
            }

            //Lets you add multiple items at one, will take either an array/collection or inidividual object
            db.donutDetails.AddRange(details);
            db.extras.AddRange(extras);

            db.SaveChanges();
        }

    }
}

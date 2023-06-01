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
          
            for(int i = 1; i < 9; i++)
            {
                DonutDetails d = dal.GetDonutDetails(i);
                d.id = 0; 
                details.Add(d);
                foreach(string e in d.extrasApi)
                {
                    extras.Add(new Extra() { id=0, extra=e });
                }
            }

            //Lets you add multiple items at one, will take either an array/collection or inidividual object
            db.donutDetails.AddRange(details);
            db.extra.AddRange(extras);

            db.SaveChanges();
        }

    }
}

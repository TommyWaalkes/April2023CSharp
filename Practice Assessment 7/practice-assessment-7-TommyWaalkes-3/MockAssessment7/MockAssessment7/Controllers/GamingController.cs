using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7.Models;

namespace MockAssessment7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamingController : ControllerBase
    {
        GameDB DB = new GameDB();

        [HttpGet("Players")]
        public List<Player> GetPlayers()
        {
            return DB.Players; 
        }

        [HttpGet("Classes")]
        public List<PlayerClass> GetPlayersClasses()
        {
            return DB.PlayerClasses;
        }

        [HttpGet("PlayerMinLevel/{level}")]
        public List<Player> PlayerMinLevel(int level)
        {
            List<Player> list = DB.Players;
            return list.Where(p => p.Level >= level).ToList();
        }

        [HttpGet("PlayersSortLevel")]
        public List<Player> PlayerLevel()
        {
            List<Player> list = DB.Players;
            return list.OrderByDescending(p => p.Level).ToList(); 
        }

        [HttpGet("PlayersOfClass/{className}")]
        public List<Player> PlayersOfClass(string className)
        {
            int classesId = -1; 

            switch(className)
            {
                case "Archer":
                    classesId = 0; 
                    break;
                case "Healer": 
                    classesId = 1;
                    break;
                case "Knight":
                    classesId = 2;
                    break;
                case "Wizard":
                    classesId = 3;
                    break;
                case "Thief":
                    classesId = 4;
                    break; 
            }

            return DB.Players.Where(p => p.PlayerClassId == classesId).ToList();
        }

        [HttpGet("PlayersOfType/{type}")]
        public List<Player> GetPlayersByType(string type)
        {
            List<Player> list = DB.Players;
            List<PlayerClass> classes = DB.PlayerClasses;
            List<Player> matches = new List<Player>();


            foreach (Player p in list)
            {
                int classId = p.PlayerClassId;

                PlayerClass pc = classes.Where(c => c.ID == p.PlayerClassId).First();

                if(pc.Type == type)
                {
                    matches.Add(p);
                }

            }

            return matches;

        }

        [HttpGet("AllPlayedClasses")]
        public List<PlayerClass> AllPlayedClasses()
        {
            List<PlayerClass> classes = new List<PlayerClass>();
            foreach (Player p in DB.Players)
            {
                PlayerClass pc = DB.PlayerClasses.Where(c => c.ID == p.PlayerClassId).First();

                if (!classes.Contains(pc))
                {
                    classes.Add(pc);
                }
            }

            return classes;
        }
    }
}

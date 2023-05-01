using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    internal class Town
    {
        public List<Villager> Villagers { get; set; } = new List<Villager>();

        public Town()
        {
            Villagers.Add(new Farmer());
            //Villagers.Add(new Slacker());
            //Villagers.Add(new Slacker());
            //Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            int totalFood = 0; 
            foreach(Villager v in Villagers)
            {
                totalFood += v.Farm();
            }

            return totalFood;
        }

        public int CalcFoodConsumption()
        {
            int totalHunger = 0;
            foreach(Villager v in Villagers)
            {
                totalHunger += v.Hunger;
            }

            return totalHunger;
        }

        public bool SurviveTheWinter()
        {
            int totalHunger = CalcFoodConsumption();
            int totalHarvest = Harvest();

            return totalHunger <= totalHarvest;
        }
    }
}

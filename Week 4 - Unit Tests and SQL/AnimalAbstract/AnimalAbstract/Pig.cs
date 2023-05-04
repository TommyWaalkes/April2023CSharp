using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    internal class Pig : Animal
    {
        public int PlantCalories { get; set; } = 0;
        public int MeatCalories { get; set; } = 0;
        public Pig() : base(3000)
        {
        }

        public override void Eat(int amount, FoodType food)
        {
            CaloriesEaten += amount;
            if(FoodType.Plants == food)
            {
                PlantCalories+= amount;
            }
            else if (FoodType.Meat == food)
            {
                MeatCalories+= amount;
            }
        }

        public override bool IsFull()
        {
            return base.IsFull() && PlantCalories >=1000 && MeatCalories >=1000;
        }
    }
}

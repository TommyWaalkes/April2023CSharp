using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    internal class Chimp : Animal
    {
        public int MeatCalories { get; set; } = 0;
        public Chimp() : base(1000)
        {
        }

        public override void Eat(int amount, FoodType food)
        {
            CaloriesEaten += amount;
            if(food == FoodType.Meat)
            {
                MeatCalories += amount;
            }
        }

        public override bool IsFull()
        {
            return base.IsFull() && MeatCalories >= 200;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    internal class Bush : Animal
    {
        public Bush() : base(50)
        {
        }

        public override void Eat(int amount, FoodType food)
        {
            if(food == FoodType.Light)
            {
                CaloriesEaten += amount;
            }
        }


    }
}

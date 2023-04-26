using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaces
{
    internal class Bush : IAnimal
    {
        //You set the value on property when you want to initalize no matter what constructor and its going to start at the same value
        //You'll set the value of a property in a constructor when you want to customize the value for each instance. 
        #region
        public int CaloriesEaten { get; set; } = 0;
        public int CaloriesNeeded { get; set; } = 50;
        public string Name { get; set; }
        #endregion

        //Note that override interface stubs, does not use the override keyword 
        public void Eat(int amount, FoodType food)
        {
            if(food == FoodType.Light)
            {
                CaloriesEaten += amount;
            }
        }

        public bool IsFull()
        {
            return CaloriesEaten >= CaloriesNeeded;
        }
    }
}

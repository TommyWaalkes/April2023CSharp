using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public enum FoodType
    {
        Plants,
        Meat, 
        Light
    }

    public abstract class Animal
    {
        public int CaloriesNeeded { get; set; }
        public int CaloriesEaten { get; set; }

        //We can never call this constructor directly, it exists purely to be used by the child classes
        public Animal(int CaloriesNeeded)
        {
            this.CaloriesNeeded = CaloriesNeeded;   
            CaloriesEaten= 0;
        }

        //Note the lack of body - this method must be overriden in any children of this class
        public abstract void Eat(int amount, FoodType food);

        public virtual bool IsFull()
        {
            if(CaloriesNeeded <= CaloriesEaten)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceConcrete
{
    class Animal
    {
        public int CaloriesNeeded { get; set; }
        public int CurrentCalories { get; set; }

        public Animal() { 
            CurrentCalories= 0;
            CaloriesNeeded = 100;
        }

        public virtual void Eat(int amount, string type)
        {
            CurrentCalories += amount;
        }

        //If a method in parent is not set to virtual, all children get the method as is
        public virtual bool IsFull()
        {
            return CurrentCalories >= CaloriesNeeded;
        }
    }
}

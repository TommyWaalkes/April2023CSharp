using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjects
{
    //In C# the convention is generally 1 class 1 file, each gets its own file
    //(though ocasionally smaller related classes may be lumped togther in the same file
    //In other OOP, this convention is strict meaning you have to do 1 class 1 file
    class Vehicle
    {
        //1) Properties 
        //2) Constructors 
        //3) Methods

        //What is the get and set here? 
        //get - return the current value of the property, making it public means any class has aaccess to that property 
        //set - allows us to change the value of property, being public any other may set that property. 
        //.Net LOVES Properties 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int TankCapacity { get; set; }
        public int CurrentGas { get; set; }

        //We'll use our constructor to fill out each property 
        public Vehicle(string Make, string Model, int Year, int TankCapacity)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.TankCapacity = TankCapacity;
            this.CurrentGas = TankCapacity;
        }

        public void Drive()
        {
            if (CurrentGas > 0)
            {
                CurrentGas--;
            }
        }

        public void RefillGas(int amount)
        {
            CurrentGas += amount;
            if(CurrentGas > TankCapacity)
            {
                CurrentGas = TankCapacity;
            }
        }

        public bool IsFull()
        {
            if(CurrentGas >= TankCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //properties are a shorthand version of the following methods (other language MUST write these out the long way) 
        public string GetMake()
        {
            return Make;
        }

        public void SetMake(string Make)
        {
            this.Make = Make;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaces
{
    public enum FoodType
    {
        Meat, 
        Plants, 
        Light
    }

    //There's no data in here and no functionality 
    //The point of interfaces is creating consistent methods between all children, while forcing the children 
    //To supply their own bodies for each method, interfaces are for organziation and not function 
    //Since interfaces have no functionality in there, there isn't a possibilty of conflict between interfaces 
    //Therefore, you may subclass as many interfaces as you want. 
    interface IAnimal
    {
        string Name { get; set; }
        //Interfaces in most languages will only have method stubs 
        //In C#, you can define properties, but without getting into, there's so many restrictions on 
        //Interface properties, that they rarely
        //It's faster to simply to create regular properties in each child. 

        //Method stubs may only have a signature, not a body, they fullfill the same purpose as abstract methods 
        public void Eat(int amount, FoodType food);

        public bool IsFull();
    }
}

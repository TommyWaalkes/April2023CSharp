using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public enum AnimalType
    {
        Bush,
        Chimp, 
        Pig
    }

    //Produce animals objects 
    //Can be set up to handle mass production 
    internal class AnimalFactory
    {
        public Animal MakeAnimal(AnimalType type)
        {
            //This is useful in 2 situations 
            //1) You have an inheritance tree with lots of children all with complex constructors 
            //2) Mass production, I need 100 chimps all with the same properties -great for setting up simulators/systems
            Animal ouput;

            switch (type)
            {
                case AnimalType.Bush:
                    return new Bush();
                case AnimalType.Chimp:
                    return new Chimp();
                case AnimalType.Pig:
                    return new Pig();
            }

            return null;
        }

        public List<Animal> MassProduceAnimals(AnimalType type, int numberOfAnimals)
        {
            List<Animal> output = new List<Animal>();

            for(int i =0; i < numberOfAnimals; i++)
            {
                Animal a = MakeAnimal(type);
                output.Add(a);
            }

            return output;
        }
    }
}

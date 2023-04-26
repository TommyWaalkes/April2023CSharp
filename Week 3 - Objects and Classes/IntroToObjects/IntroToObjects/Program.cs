namespace IntroToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is how you call a constructor
            Vehicle v = new Vehicle("Ford", "Focus", 1997, 30);
            //This is how you update a property with a new value
            v.CurrentGas = 15;
            Console.WriteLine(v.CurrentGas);

            while (v.CurrentGas > 0)
            {
                //This is how you call methods on objects 
                v.Drive();

                Console.WriteLine(v.CurrentGas);
            }

            v.RefillGas(10);
            Console.WriteLine(v.CurrentGas);
            
            //Spend a lot of time writing class and create objects and testing them 
            //Experiment! 
        }
    }
}
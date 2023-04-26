namespace CircleLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Welcome to our circle calculator");

                //Static method you call on their class and not on an object
                double rad = Validator.GetRadius();
                Circle c = new Circle(rad);
                Console.WriteLine(c);

                Console.WriteLine("Would you like to grow your circle? y/n");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    c.Grow();
                    Console.WriteLine("Larger Circle:");
                    Console.WriteLine(c);
                }
                else if (input == "n")
                {
                    Console.WriteLine("Okay lets go make another circle");
                    //Loop round to the top
                    continue;
                }
            }
        }
    }
}
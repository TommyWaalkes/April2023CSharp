namespace AnimalAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bush b = new Bush();
            Console.WriteLine(b.IsFull());
            b.Eat(50, FoodType.Light);
            Console.WriteLine(b.IsFull());

            Console.WriteLine();
            Console.WriteLine("Testing Chimp");
            Chimp c = new Chimp();
            Console.WriteLine(c.IsFull());
            c.Eat(1000, FoodType.Plants);
            Console.WriteLine(c.IsFull());
            c.Eat(300, FoodType.Meat);
            Console.WriteLine(c.IsFull());
            Console.WriteLine();
            Console.WriteLine("Testing Pig");
            Pig p = new Pig();
            Console.WriteLine(p.IsFull());
            p.Eat(3000, FoodType.Light);
            Console.WriteLine(p.IsFull());
            p.Eat(1000, FoodType.Meat);
            p.Eat(1000, FoodType.Plants);
            Console.WriteLine(p.IsFull());
        }
    }
}
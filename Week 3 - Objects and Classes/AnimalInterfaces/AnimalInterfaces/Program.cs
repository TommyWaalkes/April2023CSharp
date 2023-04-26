namespace AnimalInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bush b = new Bush();
            Console.WriteLine("Testing Bush");
            Console.WriteLine(b.IsFull());
            b.Eat(50, FoodType.Meat);
            Console.WriteLine(b.IsFull());
            b.Eat(50, FoodType.Light);
            Console.WriteLine(b.IsFull());
        }
    }
}
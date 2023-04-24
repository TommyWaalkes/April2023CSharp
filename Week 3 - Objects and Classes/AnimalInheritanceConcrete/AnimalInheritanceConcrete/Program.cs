namespace AnimalInheritanceConcrete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.IsFull());
            a.Eat(900, "plant");
            Console.WriteLine(a.IsFull());

        }
    }
}
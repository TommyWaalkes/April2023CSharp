namespace DependcyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dependcy injection has a few advantages over straight inheritance 
            //1) DI allows for the methods to be swapped in and out at runtime. 
            //2) More customization, I can inject as many different methods as I wish. I can use any combination of methods I want
            TriangleArea triangleArea = new TriangleArea();

            Shape s = new Shape(triangleArea);
            Console.WriteLine(s.GetArea(10,10));

            s.areaMethod = new CircleArea();
            Console.WriteLine(s.GetArea(10,10));
        }
    }
}
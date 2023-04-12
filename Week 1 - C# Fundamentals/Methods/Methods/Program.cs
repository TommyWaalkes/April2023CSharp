namespace Methods
{
    public class Program
    {
        public static void Main()
        {
            string name = GetUserInput("Please input your name");
            double area = GetArea(10, 5);
            Console.WriteLine("Area: "+area);
            Console.WriteLine("Is this area even: "+IsEven(area));

            double area2 = GetArea(19, 35);
            Console.WriteLine("Area 2: "+area2);
            Console.WriteLine("Is this area even: " + IsEven(area2));

            //You can use the method names as a guide to what's going on -This why you want to give your methods clear descriptive names
            double len = double.Parse(GetUserInput("Please input a length"));

            double width = double.Parse(GetUserInput("Please input a width"));

            double area3 = GetArea(len, width);
            Console.WriteLine("Area 3: "+area3);
        }

        //This acts as a math formula - I can plug in whatever numbers I want
        public static double GetArea(double length, double width)
        {
            double output = length * width;
            return output;
        }

        //This is an example of a validation -checking for certain conditions 
        public static bool IsEven(double num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        //This method will help gather user input 
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
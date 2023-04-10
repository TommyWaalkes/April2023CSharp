//In the current version of C#, the main method is optional 
Console.WriteLine("Enter a Radius:");
string r = Console.ReadLine();

//Takes in a string and converts it to a double
double radius = double.Parse(r);
//double rad = double.Parse(Console.ReadLine());

double area = radius * radius * Math.PI;
Console.WriteLine("Area: " + area);

double circumference = Math.PI * 2 * radius;
Console.WriteLine("Circumference: "+circumference);
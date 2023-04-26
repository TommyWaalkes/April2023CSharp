//Console.WriteLine("Exercise 6");
//bool goOn = true;

//do
//{
//    Console.WriteLine("Hello World!");
//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);

//Console.WriteLine();
//Console.WriteLine("Exercise 7");

//do
//{
//    Console.WriteLine("Please input a phrase for me to repeat");
//    string input2 = Console.ReadLine();
//    Console.WriteLine(input2);
   
//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);

//Console.WriteLine();
//Console.WriteLine("Exercise 9");
//Console.WriteLine("Please input a language and I will print hello world in that language: ");
//string lang = Console.ReadLine();

//switch (lang)
//{
//    case "english":
//        Console.WriteLine("Hello World!");
//        break;
//    case "latin":
//        Console.WriteLine("Salve munde!");
//        break;
//    case "spanish":
//        Console.WriteLine("Hola mundo!");
//        break;
//    //If I don't find any matches run the default, this fills the same purpose as else block 
//    default:
//        Console.WriteLine("I don't know that language");
//        break;
//}
//Console.WriteLine();
//Console.WriteLine("Exercise 10");
//Console.WriteLine("Please input your height in inches");
//double height = double.Parse(Console.ReadLine());

//if (height < 54)
//{
//    Console.WriteLine("You are not tall enough to ride the raptor, you must be 54 inches tall minimum");
//}
//else
//{
//    Console.WriteLine("You are tall enough to ride the raptor, go on ahead!");
//}

//Console.WriteLine();
//Console.WriteLine("Exercise 11");
//do
//{
//    for(int i =0; i <=9; i++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
   
//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);

//Console.WriteLine();
//Console.WriteLine("Exercise 12");
//do
//{
//    for (int i = 9; i >=0; i--)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();

//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);
//Console.WriteLine();
//Console.WriteLine("Exercise 13");
//do
//{
//    Console.WriteLine("Please input a number:");
//    int num = int.Parse(Console.ReadLine());
//    for (int i = num; i >= 0; i--)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();

//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);
//Console.WriteLine();
//Console.WriteLine("Exercise 14");

//do
//{
//    Console.WriteLine("Please input a number:");
//    int num = int.Parse(Console.ReadLine());
//    for (int i = 1; i <= num; i++)
//    {
//        Console.Write((i*i)+ " ");
//    }
//    Console.WriteLine();

//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);

//Console.WriteLine();
//Console.WriteLine("Exercise 15");

//do
//{
//    Console.WriteLine("Please input a number:");
//    int num = int.Parse(Console.ReadLine());
//    for (int i = 1; i <= num; i++)
//    {
//        Console.Write((i * i * i) + " ");
//    }
//    Console.WriteLine();

//    Console.WriteLine("Would you like to continue? y/n");

//    string input = Console.ReadLine();
//    if (input == "y")
//    {
//        goOn = true;
//    }
//    else
//    {
//        //Lets asumme the user does not want to continue
//        goOn = false;
//    }
//} while (goOn == true);
//Console.WriteLine();
Console.WriteLine("Exercise 16");
for(int i = 0; i < 10; i++)
{
    for(int j = 0; j<i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
string output = "*";
for(int i = 0; i < 9; i++)
{
    Console.WriteLine(output);
    output += "*";
}

Console.WriteLine();
Console.WriteLine("Exercise 19");
Console.WriteLine("Please input a number");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Please input another number");
int num2 = int.Parse(Console.ReadLine());

int total = 0; 
for(int i = num; i<=num2; i++)
{
    total += i;
}
Console.WriteLine("Total: "+total);

Console.WriteLine();
Console.WriteLine("Exercise 20");

Console.WriteLine("Please input a number");
int num3 = int.Parse(Console.ReadLine());

int product = num3 * (num3 - 1) * (num3 - 2);
Console.WriteLine(product);

Console.WriteLine("Solving it using a for loop:");

int total3 = 1;
for(int i = num3; i>=num3-2; i--)
{
    total3 *= i;
}
Console.WriteLine(total3);
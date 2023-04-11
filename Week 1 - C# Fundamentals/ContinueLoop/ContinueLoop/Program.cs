//Many of our early lab ask you to allow the user to run the program if they choose to. 

//The do block gets run first and end condition is checked second, you really only need to use this if you want 
//your loop to run once no matter, (to be honest doesn't happen often) 
//string input = "";
//do
//{
//    //Code goes here 
//    Console.WriteLine("Hey would you like to continue? y/n");
//    input = Console.ReadLine();
//    if(input != "y")
//    {
//        Console.WriteLine("Goodbye!");
//    }
//} while (input=="y");

//While true runs infinitely until it find a break statement
//while (true)
//{
//Code goes here

//there are 3 cases we care about
//1) the user wants to continue
//2) The user wants to stop 
//3) The user inputs something other than y or n 


//    string input2 ="";
//    while (input2 != "y" || input2 != "n")
//    {
//        Console.WriteLine("Would you like to continue? y/n");
//        input2 = Console.ReadLine();
//        if (input2 == "y")
//        {
//            break;
//        }
//        else if (input2 == "n")
//        {
//            Console.WriteLine("Goodbye!");
//            break;
//        }
//        else
//        {
//            //Assume the user wants to run again 
//            //Assume the user wants to stop 
//            //Try getting user input again
//            Console.WriteLine("I didn't understand that, let's try again");
//            continue;
//        }
//    }

//    if (input2 == "n")
//    {
//        break;
//    }

//}

//Method Way
public class Program
{
    public static void Main()
    {
        bool goOn = true; 
        while(goOn == true)
        {
            //Code goes here

            goOn = Continue();
        }
    }
    public static bool Continue()
    {
        Console.WriteLine("Would you like to continue? y/n");
        string input3 = Console.ReadLine();

        //When you hit a return statement it ends the method 
        if(input3 == "y")
        {
            return true;
        }
        else if(input3 == "n")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("Hey I didn't understand that lets try again!");
            //We call the method to start over from the top 
            return Continue();
        }
    }
}


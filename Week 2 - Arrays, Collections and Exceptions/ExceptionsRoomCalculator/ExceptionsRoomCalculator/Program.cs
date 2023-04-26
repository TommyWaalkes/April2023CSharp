using System.Globalization;
using System.Reflection;

namespace ExceptionsRoomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator.");
            Console.WriteLine("Please input a width");

            //Wrap try around the lines you think may possibly throw an exception
            //Don't wrap all of your code in a try block -if an exception is thrown it becomes harder
            //To figure where it came from, thought the stack trace does help with finding it. 
            bool tryWidth = false;

            double width = -1;
            while (tryWidth == false)
            {
                try
                {
                    //Try catch blocks are still block just like loops, 
                    //What's declared stops exising once outside of them
                    width = double.Parse(Console.ReadLine());
                    tryWidth= true;
                }
                //What is that e here? 
                //e is a variable that exist just in the catch block 
                //its purpose is to give access to information on the exception 
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                    //The stack trace shows the lines numbers involved in the exception 
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine("That was not a valid input please input a decimal number");
                    Console.WriteLine("lets try that again");
                    continue;
                }
            }


            Console.WriteLine("Please input a length");
            //This should be set by tryParse, if it's not we need to treat it as an error 
            //-1 is the sign for either index not found or an error has occurred
            double length = -1;

            //the out keyword is a special keyword to go on a method parameter, if the method works properly
            //The value of the varible feed into the out parameter will be updated with the result.
            //Out allows to update 2 different variables at once, usually out is most used with built in methods 
            //For our course it's just tryParse()
            bool lenWorked = false;
            while (lenWorked != true)
            {
                lenWorked = double.TryParse(Console.ReadLine(), out length);

                if (lenWorked == false)
                {
                    Console.WriteLine("I'm sorry please input a valid decimal number for length");
                    Console.WriteLine("Lets try again");
                    continue;
                }
            }

            double area = length * width;
            Console.WriteLine(area);

            int[] nums = { 10, 20, 30 };
            try
            {
                Console.WriteLine("Please select a number you wish to pull out of your array: 0 to " + (nums.Length - 1));
                int index = int.Parse(Console.ReadLine());

                if(index < 0)
                {
                    throw new Exception("That number was negative, and we don't negativity in our program, negative indexes are NOT useable");
                }

                int num = nums[index];
                Console.WriteLine(num);
            }
            catch(FormatException e)
            {
                Console.WriteLine("That was not a valid number, please try again");
                //For the sake of time I'm continue loop logic, but you would tell the loop to try again
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("That was not a valid index please input a number 0 to " + (nums.Length -1));
                //Retry logic goes here
            }
            catch (Exception e)
            {
                //This will catch any exception thrown that the early don't handle
                Console.WriteLine(e.Message);
            }

            int[] nums2 = { 10, 20, 30 };
            int index2 = int.Parse(Console.ReadLine());
            //Handling bad input to a Parse can be only done by exceptions 
            //But you could if preferred if statements use tryPare here instead



            //Range check for our array
            //If statements are smoother for range checks
            if(index2 <0 || index2 >= nums2.Length)
            {
                Console.WriteLine($"{index2} was out of range, please input a number between 0 and {nums2.Length -1}");
            }
            else
            {
                //Continue on normally
            }
        }
    }
}
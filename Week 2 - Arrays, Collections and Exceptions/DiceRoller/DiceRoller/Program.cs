namespace DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                try
                {
                    string input = GetUserInput("Please input how many sides you want for your dice");
                    int sides = int.Parse(input);
                    int roll1 = RolNumber(1, sides);
                    int roll2 = RolNumber(1, sides);
                    Console.WriteLine($"Roll 1: {roll1}");
                    Console.WriteLine($"Roll 2: {roll2}");

                    if(sides == 6)
                    {
                        string result1 = CheckRolls(roll1, roll2);
                        string result2 = CheckTotals(roll1, roll2);
                        Console.WriteLine(result1);
                        Console.WriteLine(result2);
                    }
                    else if(sides == 20)
                    {
                        string result1 = CheckDndRolls(roll1);
                        string result2 = CheckDndRolls(roll2);
                        Console.WriteLine(result1);
                        Console.WriteLine(result2);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("That was not a valid number, please input a postitive number");
                    Console.WriteLine("Let's try again");
                }

                goOn = Continue();
            }
        }

        //If you do game development, spend a lot of time getting to know how random number generation
        //Many type of games use tons of randomness
        public static int RolNumber(int min, int max)
        {
            Random r = new Random();
            //The min is inclusive and the max is exclusive
            int roll = r.Next(min, max + 1);
            return roll;
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            return response;
        }

        public static bool Continue()
        {
            string input = GetUserInput("Would you like to roll again? y/n");

            if(input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I did not understand that, lets try again!");
                return Continue();
            }
        }

        public static string CheckRolls(int roll1, int roll2)
        {
            if(roll1 == 1 && roll2== 1)
            {
                return "Snake Eyes";
            }
            else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
            {
                return "Ace Duece";
            }
            else if(roll1 == 6 && roll2 == 6)
            {
                return "Box Cars";
            }

            return "";
        }

        public static string CheckTotals(int roll1, int roll2)
        {
            int total = roll1+ roll2;
            if(total == 7 || total == 11)
            {
                return "Win!";
            }
            else if(total == 2 || total == 3 || total == 12)
            {
                return "Craps";
            }

            return "";
        }

        public static string CheckDndRolls(int roll)
        {
            if(roll == 20)
            {
                return "Critical Hit!";
            }
            else if (roll == 1)
            {
                return "Critical Miss!";
            }

            return "";
        }
    }
}
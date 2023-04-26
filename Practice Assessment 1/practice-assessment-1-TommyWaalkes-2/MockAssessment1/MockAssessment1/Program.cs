namespace MockAssessment1
{
    public class Program
    {
        //The assessment may or may not ask for a main method, but I encourage to make one regardless to test your code
        //If the assessment does not ask for a main method, you will not be graded for whats in there
        public static void Main()
        {
            Console.WriteLine("Compare 5 and 5: " + IsSame(5,5));
            Console.WriteLine("Compare 10 and 12: "+IsSame(10,12));

            Console.WriteLine(Subtract(20,15));
            Console.WriteLine(Subtract(10,19));

            Console.WriteLine("2 Floors: "+ FindBuildingType(2));
            Console.WriteLine("10 Floors: " + FindBuildingType(10));
            Console.WriteLine("30 Floors: " + FindBuildingType(30));
            Console.WriteLine("49 Floors: " + FindBuildingType(49));
            Console.WriteLine("50 Floors: " + FindBuildingType(50));
            Console.WriteLine("100 Floors: " + FindBuildingType(100));



        }
        public static bool IsSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static string FindBuildingType(int floors)
        {
            if (floors <= 3)
            {
                return "This is a house!";

            }
            else if(floors <= 10)
            {
                return "This is an office building ";
            }
            else if(floors <= 49)
            {
                return "this is a skyscraper";
            }
            else
            {
                return "This is a super skyscraper";
            }
        }
    }
}
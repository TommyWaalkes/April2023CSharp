namespace ArraysCodeDemo
{
    public class Program
    {
        public static void Main()
        {
            double[] prices = { 19.99, 3.50, 999.99, 4.99 };
            double avg = AverageArray(prices);
            Console.WriteLine(avg);

            //This doesn't give me anything useful 
            Console.WriteLine(prices);

            PrintArray(prices);
            PriceIncrease(prices, 10);
            Console.WriteLine();
            PrintArray(prices);
            double[] prices2 = new double[prices.Length];
            prices.CopyTo(prices2, 0);
            Console.WriteLine();
            PrintArray(prices2);
            PriceIncrease(prices2, 75);
            Console.WriteLine();
            PrintArray(prices2);
            PrintArray(prices);
            Console.WriteLine();
            string[] guestList = { "Tommy", "Joey", "Phil", "Skeezy" };
            Console.WriteLine(OnGuestList(guestList, "Skeezy"));
            Console.WriteLine(OnGuestList(guestList, "Jimmy"));

            string guest = SelectGuest(guestList);
            Console.WriteLine("You selected "+guest);

            //These all come from a library named LINQ - Language Intergrated Querying 
            Console.WriteLine("Prices 2 sum: " + prices2.Sum());
            Console.WriteLine("Price 2 Min: "+prices2.Min());
            Console.WriteLine("Price 2 Max: " +prices2.Max());
            Console.WriteLine("Price 2 Average: "+ prices2.Average());

        }

        public static bool OnGuestList(string[] guests, string name)
        {
            if (guests.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This is something many of the labs from here on out will ask for
        public static string SelectGuest(string[] guests)
        {
            PrintGuestList(guests);
            Console.WriteLine("Please select a guest:");
            string input = Console.ReadLine();
            int pick = int.Parse(input) - 1;
            return guests[pick];
        }

        //Changes you make to an array in a method will persist elsewhere
        public static void PriceIncrease(double[] prices, double precentIncrease)
        {
            //Foreach loops may only look at the value of items in array 
            //It may not alter them or remove them or add in new items
            //Foreach loops look at what the end point of the array and its values when it first runs 
            //Changes mess that up

            //We have to use a for loop here
            //foreach(double price in prices)
            //{
            //    price *= precentIncrease;
            //}
            double increase = (precentIncrease / 100) + 1;

            for(int i = 0; i < prices.Length; i++)
            {
                prices[i] *= increase;
                prices[i] = Math.Round(prices[i], 2);
            }
        }

        public static void PrintGuestList(string[] guests)
        {
            for (int i = 1; i <= guests.Length; i++)
            {
                Console.WriteLine(i + " " + guests[i-1]);
            }
        }

        public static void PrintArray(double[] nums)
        {
            for(int i =0; i < nums.Length; i++)
            {
                Console.WriteLine(i + " "+nums[i]);
            }
        }

        public static double AverageArray(double[] nums)
        {
            double sum = 0;
            foreach(double num in nums)
            {
                sum += num;
            }

            //Ceiling rounds decimals up 
            //Floor rounds down
            return Math.Round(sum/nums.Length, 2);
        }
    }
}
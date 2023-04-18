namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942, 50, 90, 4, 9, 101 };

            Console.WriteLine("Min Value of nums");
            int min = nums.Min();
            Console.WriteLine("Min number is: " + min);
            int max = nums.Max();
            Console.WriteLine("Max number is: " + max);

            int maxUnder5000 = nums.Where( num => num <= 5000).Max();
            Console.WriteLine("Max num under 5000: " + maxUnder5000);

            int maxUnder10000 = nums.Where(num => num <= 10000).Max();
            Console.WriteLine("Max num under 10000: " + maxUnder10000);

            List<int> between10and100 = nums.Where(num => 10 <= num && num <= 100).ToList();

            Console.WriteLine("Numbers between 10 and 100");
            foreach(int num in between10and100)
            {
                Console.WriteLine(num);
            }

            List<int> between100000and999999 = nums.Where(num => 100000 <= num && num <= 999999).ToList();

            Console.WriteLine("Numbers between 100000 and 999999");
            foreach (int num in between100000and999999)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("Even Number Count:");
            int evensCount = nums.Where(num => num%2==0).Count();
            Console.WriteLine(evensCount);

            //num => num means don't do any filtering, leave the list as is.
            List<int> orderedNums = nums.OrderByDescending(num => num).ToList();

            Console.WriteLine("Order Nums Descending");
            foreach(int n in orderedNums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
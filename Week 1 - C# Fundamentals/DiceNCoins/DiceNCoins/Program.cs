namespace DiceNCoins
{
    public class Program
    {
        public static void Main() {
            Console.WriteLine("Please input a minimum number: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input a Maximum number: ");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(CoinFlip());
                Console.WriteLine(DiceRoll(min,max));
            }
        }

        public static string CoinFlip()
        {
            Random r = new Random();
            int roll = r.Next(1,101);

            //This is handy for driectly setting a percent chance for something to happen
            if(roll >= 50)
            {
                return "heads";
            }
            else
            {
                return "tails";
            }
        }

        public static int DiceRoll(int min, int max)
        {
            Random r = new Random(); 
            return r.Next(min, max + 1);
        }
    }
}
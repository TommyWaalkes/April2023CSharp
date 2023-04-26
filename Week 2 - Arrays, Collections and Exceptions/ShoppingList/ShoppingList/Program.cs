namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> itemsToPrices = new Dictionary<string, decimal>();
            itemsToPrices.Add("Apples", 5.99m);
            itemsToPrices.Add("Frozen Pizza", 7.99m);
            itemsToPrices.Add("Beer", 10.99m);
            itemsToPrices.Add("Onions", 3.99m);

            List<string> shoppingCart = new List<string>();
            Dictionary<char, string> lettersToItems = new Dictionary<char, string>();


            //Dictionaries are lists of key value pairs
            //Research to Dictionary <- This method only exists in C# 
            itemsToPrices = itemsToPrices.OrderBy(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
            char let = 'a';
            foreach(string item in itemsToPrices.Keys)
            {
                //All character have a number index, this allows to perfrom math operations on characters 
                lettersToItems.Add(let, item);
                let++;
            }
            
            bool goOn = true; 
            while(goOn == true)
            {
                let = 'a';

                //In this case since were using a dictionary i is a key value pair
               
                foreach(KeyValuePair<string, decimal> kvp in itemsToPrices)
                {
                    Console.WriteLine(let +") "+kvp.Key + " "+kvp.Value);
                    let++;
                }
                Console.WriteLine("Which item would you like to add to your cart? select either by item name or letter");

                string input = Console.ReadLine();
                char c = '0';
                if(input.Length == 1)
                {
                    c = char.Parse(input);
                }

                if (itemsToPrices.ContainsKey(input))
                {
                    shoppingCart.Add(input);
                }
                else if (lettersToItems.ContainsKey(c))
                {
                    string item = lettersToItems[c];
                    shoppingCart.Add(item);
                }
                    //Index 0 should map to a and then everything else should follow from that
                else
                {
                    Console.WriteLine("Item not found, let's try again");
                    continue;
                }
                Console.WriteLine();
                goOn = Continue();
            }

            Decimal total = 0;
            foreach(string item in shoppingCart)
            {
                Decimal price = itemsToPrices[item];
                Console.WriteLine(item +" "+ price);
                total += price;
            }
            Console.WriteLine(total);
            Dictionary<string, decimal> boughtItems = itemsToPrices.Where(kvp => shoppingCart.Contains(kvp.Key)).ToDictionary(i => i.Key, i => i.Value); 
            //To find the most/least expensive item bought we need to make another dictionary containing just the items 
            //from the shopping cart along with their prices

            decimal mostExpensive = boughtItems.Values.Max();
            decimal leastExpensive = boughtItems.Values.Min();
            List<string> mostExpensiveItems = new List<string>();
            List<string> leastExpensiveItems = new List<string>();
            //We have to do it this way since there may be multiple items tied for most expensive
            foreach(string item in shoppingCart)
            {
                decimal price = itemsToPrices[item];
                if(price == mostExpensive)
                {
                    mostExpensiveItems.Add(item);
                }
                if(price == leastExpensive)
                {
                    leastExpensiveItems.Add(item);
                }
            }

            Console.WriteLine("Most Expensive Items:");
            foreach(string item in mostExpensiveItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Least Expensive Items:");
            foreach(string item in leastExpensiveItems)
            {
                Console.WriteLine(item);
            }


        }

        //We're making a loop that keeps going until we get a y or n, but instead of a traditional loop 
        //We're setting up the loop using methods
        public static bool Continue()
        {
            Console.WriteLine("Would you like to go again? y/n");
            string input = Console.ReadLine();
            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand that lets try again");
                return Continue();
            }
        }
    }
}
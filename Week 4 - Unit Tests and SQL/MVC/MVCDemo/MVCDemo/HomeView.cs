using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo
{
    public class HomeView
    {
        public string Display()
        {
            Console.WriteLine("Welcome to our movie APP");
            Console.WriteLine("Would you like to see our listing of movies? Y/N");

            string input = Console.ReadLine().ToLower();
            if(input == "n")
            {
                Console.WriteLine("Good bye!");
                return "n";
            }
            else if(input == "y")
            {
                return "y";
            }
            else
            {
                Console.WriteLine("Didn't understand lets try again");
                return Display();
            }
        }
    }
}

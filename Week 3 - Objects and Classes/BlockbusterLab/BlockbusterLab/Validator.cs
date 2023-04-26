using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class Validator
    {
        //I'm making this static so I can call it anywhere without having to make an object
        public static bool WithinRange(int index, IEnumerable<string> collection)
        {
            if(index < collection.Count() && index >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WithinRange(int index, IEnumerable<Movie> collection)
        {
            if (index < collection.Count() && index >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetIntFromUser(string message)
        {
            Console.WriteLine(message);

            try
            {
                int num = int.Parse(Console.ReadLine());
                return num;
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid integer lets try again");
                return GetIntFromUser(message);
            }
        }
    }
}

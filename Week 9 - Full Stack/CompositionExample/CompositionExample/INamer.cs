using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal interface INamer
    {
        public string PickName();
    }

    public class UserNamer : INamer
    {
        public string PickName()
        {
            Console.WriteLine("Please input what you wish to name your RPS User");
            return Console.ReadLine();
        }
    }

    public class RandomNamer: INamer
    {
        public string PickName()
        {
            List<string> names = new List<string>() { "Rocky", "Randy", "Cutty", "Papery"};
            Random r = new Random();
            int pick = r.Next(0, names.Count);

            return names[pick];
        }
    }
}

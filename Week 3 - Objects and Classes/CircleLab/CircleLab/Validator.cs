using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    class Validator
    {
        public static double GetRadius()
        {
            try
            {
                Console.WriteLine("Please input a decimal radius");
                double radius = double.Parse(Console.ReadLine());
                return radius;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input was not a valid radius, lets try again");
                return GetRadius();
            }
        }
    }
}

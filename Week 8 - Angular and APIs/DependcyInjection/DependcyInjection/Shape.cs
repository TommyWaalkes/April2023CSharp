using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    internal class Shape
    {
        public IGetArea areaMethod { get; set; }

        //This is where my dependency injection occurs 
        //Any version of of get area can be passed in here
        public Shape(IGetArea areaMethod)
        {
            this.areaMethod = areaMethod;
        }

        public double GetArea(double length, double width)
        {
            return areaMethod.GetArea(length, width);
        }
    }
}

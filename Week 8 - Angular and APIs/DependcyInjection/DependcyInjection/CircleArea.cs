using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    internal class CircleArea : IGetArea
    {
        public double GetArea(double length, double width)
        {
            //we'll use the length as radius
            return Math.PI * length * length;
        }
    }
}

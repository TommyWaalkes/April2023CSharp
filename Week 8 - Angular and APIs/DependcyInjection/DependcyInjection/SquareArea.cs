using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    internal class RectArea : IGetArea
    {
        public double GetArea(double length, double width)
        {
            return length * width;
        }
    }
}

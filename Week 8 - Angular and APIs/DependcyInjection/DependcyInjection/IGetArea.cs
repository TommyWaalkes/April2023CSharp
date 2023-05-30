using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    internal interface IGetArea
    {
        //In C# interfaces, you may only have method stubs, no constructor and no data. 
        public double GetArea(double length, double width);
    }
}

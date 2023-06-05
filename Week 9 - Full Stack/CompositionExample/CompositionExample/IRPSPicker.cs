using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal interface IRPSPicker
    {
        public RockPaperScissors ChoosesRPS();
    }

    public class RockThrower : IRPSPicker
    {
        public RockPaperScissors ChoosesRPS()
        {
            return RockPaperScissors.Rock;
        }
    }
}

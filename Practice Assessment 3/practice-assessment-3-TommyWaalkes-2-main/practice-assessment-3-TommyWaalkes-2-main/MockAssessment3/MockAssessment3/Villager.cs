using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    public abstract class Villager
    {
        public int Hunger { get; set; }

        public abstract int Farm();
    }

    public class Farmer : Villager
    {
        public Farmer() {
            Hunger = 1;
        }
        public override int Farm()
        {
            return 2;
        }
    }

    public class Slacker : Villager
    {
        public Slacker()
        {
            Hunger = 3;
        }
        public override int Farm()
        {
            return 0;
        }
    }
}

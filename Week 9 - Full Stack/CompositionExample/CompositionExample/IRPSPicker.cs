using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal interface IRPSPicker
    {
        public RockPaperScissors ChooseRPS();
    }

    public class RockThrower : IRPSPicker
    {
        public RockPaperScissors ChooseRPS()
        {
            return RockPaperScissors.Rock;
        }
    }

    public class RandomThrower : IRPSPicker
    {
        public RockPaperScissors ChooseRPS()
        {
            Random r = new Random();
            int pick = r.Next(0, 3);
            switch (pick)
            {
                case 0:
                    return RockPaperScissors.Rock;
                case 1:
                    return RockPaperScissors.Scissors;
                case 2:
                    return RockPaperScissors.Paper;
                default:
                    return RockPaperScissors.Rock;
            }
        }
    }

    public class UserThrow : IRPSPicker
    {
        public RockPaperScissors ChooseRPS()
        {
            Console.WriteLine("Choose a value: ");
            Console.WriteLine("0: Rock");
            Console.WriteLine("1: Paper");
            Console.WriteLine("2: Scissors");

            try
            {
                int pick = int.Parse(Console.ReadLine());
                switch (pick)
                {
                    case 0:
                        return RockPaperScissors.Rock;
                    case 1:
                        return RockPaperScissors.Paper;
                    case 2:
                        return RockPaperScissors.Scissors;
                    default:
                        return RockPaperScissors.Rock;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("I didn't understand that lets try again");
                return ChooseRPS();
            }
        }
    }
}

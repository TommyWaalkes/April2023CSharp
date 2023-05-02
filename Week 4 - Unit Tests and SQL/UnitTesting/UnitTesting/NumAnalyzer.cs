using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class NumAnalyzer
    {
        public string OddEvenPrime(int num)
        {
            if(num == 2)
            {
                return "prime";
            }
            bool isEven = num % 2 == 0;

            if (isEven)
            {
                return "even";
            }
            else
            {
                if(num== 1)
                {
                    return "odd";
                }
                //Only odd numbers can be prime (except for 2) 
                for( int i = 3; i < num; i++)
                {
                    //Why do we start at 3? 
                    //1 divides evenly into everything 
                    //2 we already checked and even numbers can't be prime

                    if(num % i == 0)
                    {
                        return "odd";
                    }
                }

                return "prime";
            }
        }
    }
}

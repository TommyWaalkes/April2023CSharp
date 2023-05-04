using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDReview
{
    internal class NumsToEng
    {
        public string ConvertNum(int num)
        {
           string result = "";
            if (num < 10)
            {
                result += OnesPlaces(num);
            }
            else if(num > 10 && num < 20)
            {
                result += TeensPlace(num);
            }
            else if (num < 100)
            {
                string sNum = num.ToString();
                int onesPlace = int.Parse(sNum[1].ToString());
                int tensPlace = int.Parse(sNum[0].ToString()) *10;
                if (onesPlace != 0)
                {
                    result += TensPlace(tensPlace) + "-";
                    result += OnesPlaces(onesPlace);
                }
                else
                {
                    result += TensPlace(tensPlace);
                }
            }

           return result;
        }

        public string OnesPlaces(int num)
        {
            Dictionary<int, string> numsMap = new Dictionary<int, string>();
            numsMap.Add(0, "zero");
            numsMap.Add(1, "one");
            numsMap.Add(2, "two");
            numsMap.Add(3, "three");
            numsMap.Add(4, "four");
            numsMap.Add(5, "five");
            numsMap.Add(6, "six");
            numsMap.Add(7, "seven");
            numsMap.Add(8, "eight");
            numsMap.Add(9, "nine");

            string result = numsMap[num];

            return result;

        }

        public string TensPlace(int num)
        {
            Dictionary<int, string> numsMap = new Dictionary<int, string>();
            numsMap.Add(10, "ten");
            numsMap.Add(20, "twenty");
            numsMap.Add(30, "thirty");
            numsMap.Add(40, "forty");
            numsMap.Add(50, "fifty");
            numsMap.Add(60, "sixty");
            numsMap.Add(70, "seventy");
            numsMap.Add(80, "eighty");
            numsMap.Add(90, "ninety");

            string result = numsMap[num];
            return result;
        }

        public string TeensPlace(int num)
        {

            Dictionary<int, string> numsMap = new Dictionary<int, string>();
            numsMap.Add(11, "eleven");
            numsMap.Add(12, "twelve");
            numsMap.Add(13, "thirteen");
            numsMap.Add(14, "forteen");
            numsMap.Add(15, "fifteen");
            numsMap.Add(16, "sixteen");
            numsMap.Add(17, "seventeen");
            numsMap.Add(18, "eighteen");
            numsMap.Add(19, "nineteen");

            string result = numsMap[num];
            return result;
        }
    }
}

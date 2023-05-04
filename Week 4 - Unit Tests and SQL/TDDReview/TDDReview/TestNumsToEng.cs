using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDReview
{
    public class TestNumsToEng
    {
        [Theory]
        [InlineData(3, "three")]
        [InlineData(7, "seven")]
        [InlineData(5, "five")]
        [InlineData(20, "twenty")]
        [InlineData(40, "forty")]
        [InlineData(32, "thirty-two")]
        [InlineData(99, "ninety-nine")]
        [InlineData(10, "ten")]
        [InlineData(12, "twelve")]
        [InlineData(11, "eleven")]
        [InlineData(19, "nineteen")]


        public void TestConvertToEnglish(int num, string expected)
        {
            //Arrange 
            NumsToEng ne = new NumsToEng();

            //Act 
            string actual = ne.ConvertNum(num);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class TestNumAnalyzer
    {
        //Odd 
        //Even 
        //Prime

        [Theory]
        [InlineData(8, "even")]
        [InlineData(9, "odd")]
        [InlineData(5, "prime")]
        [InlineData(2, "prime")]
        [InlineData(1, "odd")]
        public void TestEvenOddPrime(int num, string expected)
        {
            //Arrange 
            NumAnalyzer na = new NumAnalyzer();

            //Act 
            string actual = na.OddEvenPrime(num);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}

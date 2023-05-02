using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class TestFizzBuzz
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(7, "")]
        [InlineData(15, "FizzBuzz")]
        public void TestDoFizzBuzz(int num, string expected)
        {
            FizzBuzz fb = new FizzBuzz();
            string actual = fb.DoFizzBuzz(num);

            Assert.Equal(expected, actual);
        }
    }
}

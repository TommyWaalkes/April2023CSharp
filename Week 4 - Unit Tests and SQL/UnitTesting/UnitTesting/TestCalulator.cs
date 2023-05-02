using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    //Unit testing classes need to be set to public
    public class TestCalulator
    {
        [Theory]
        [InlineData(5,6,11)]
        [InlineData(5,5,10)]
        [InlineData(11,16, 27)]
        public void TestAddTheory(int num1, int num2, int expected)
        {
            //Arrange
            Calculator c = new Calculator();

            //Act 
            int actual = c.Add(num1, num2);

            //Assert 
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestAdd()
        {
            //Arrange
            Calculator c = new Calculator();
            int expected = 3;

            //Act 
            int actual = c.Add(1, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd2()
        {
            //Arrange 
            Calculator c = new Calculator();
            int expected = 7;

            //Act 
            int actual = c.Add(2, 5);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,6)]
        [InlineData(-10, 6)]
        [InlineData(7, 11)]
        [InlineData(15, 0)]
        public void TestSubtract(int num1, int num2)
        {
            //Arrange 
            Calculator c = new Calculator();
            int expected = num1 - num2;

            //Act 
            int actual = c.Sub(num1, num2);

            //Assert 
            Assert.Equal(expected, actual);
        }

    }
}

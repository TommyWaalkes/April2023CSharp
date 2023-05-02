using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class TestPassword
    {
        [Theory]
        [InlineData("helloworld", false)]
        [InlineData("short", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("Helloworld", true)]
        [InlineData("HELLOWORLD", false)]
        public void CheckPassword(string password, bool expected)
        {
            //Arrange 
            PasswordVerifier pv = new PasswordVerifier();

            //Act 
            bool actual = pv.Verify(password);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

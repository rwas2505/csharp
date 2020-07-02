using EratosthenesV2._0;
using System;
using Xunit;

namespace PrimeFactorsUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            string expected = "22235";
            var prog = new Ryan();

            //act
            string actual = prog.ShowFactors();

            //assert
            Assert.Equal(expected, actual);
        }
        // [Fact]
        // public void Test2()
        // {
        //     //arrange
        //     int a = 2;
        //     int b = 3;
        //     string expected = "5";
        //     var gen = new Generator();

        //     //act
        //     string actual = gen.Primer(a, b);

        //     //assert
        //     Assert.Equal(expected, actual);
        // }
    }
}

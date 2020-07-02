using EratosthenesV2._0;
using System;
using Xunit;

namespace PrimeFactorsUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test120()
        {
            //arrange
            string expected = "22235";
            var prog = new Ryan();

            //act
            string actual = prog.ShowFactors(120);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test50()
        {
            //arrange
            string expected = "255";
            var prog = new Ryan();

            //act
            string actual = prog.ShowFactors(50);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            //arrange
            string expected = "22";
            var prog = new Ryan();

            //act
            string actual = prog.ShowFactors(4);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}

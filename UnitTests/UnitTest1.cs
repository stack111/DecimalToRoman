using System;
using DecimalToRoman;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MI", 1001)]
        [InlineData("VMM", 1995)]
        [InlineData("VXMM", 1985)]
        [InlineData("VXVX", 10)]
        [InlineData("III", 3)]
        public void DDT(string numeral, int expected)
        {
            RomanNumeral roman = new RomanNumeral(numeral);
            Assert.Equal(expected, roman.ToDecimal());
        }
    }
}

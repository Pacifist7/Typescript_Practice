using GrandCircus;
using System;
using Xunit;

namespace CalculatorTest
{
    public class CalcTest
    {
        [Fact]

        public void TestSum()
        {
            var calc = new Calculator();

            var sum = calc.CalcSum(15, 20);

            Assert.Equal(35, sum);
        }
    }
}

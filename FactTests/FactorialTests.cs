using Xunit;
using FactorialCalculator;
using System;

namespace FactorialTests
{
    public class FactorialCalculatorTests
    {
        private readonly FactorialCalculator.FactorialCalc calculator; 

        public FactorialCalculatorTests()
        {
            calculator = new FactorialCalculator.FactorialCalc(); 
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectFactorial_ForPositiveNumber()
        {
            int number = 5;
            long expected = 120; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ShouldReturnOne_ForZero()
        {
            int number = 0;
            long expected = 1; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ShouldThrowArgumentException_ForNegativeNumber()
        {
            int number = -1;

            Assert.Throws<ArgumentException>(() => calculator.Calculate(number));
        }
    }
}

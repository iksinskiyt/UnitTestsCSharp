using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {

        [Fact]
        public void Add_ShouldCalculate() {
            double a = 5;
            double b = 4;
            double expected = 9;
            
            double actual = Calculator.Add(a,b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 2.25, 23.25)]
        [InlineData(-5, 3, -2)]
        [InlineData(double.MaxValue, 3, double.MaxValue)]
        public void Theory_Add_ShouldCalculate(double a, double b, double expected) {
            double actual = Calculator.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_ShouldntCalculate()
        {
            double a = 5;
            double b = 5;
            double expected = 9;

            double actual = Calculator.Add(a, b);

            Assert.NotEqual(expected, actual);
        }


        [Theory]
        [InlineData(8,4,2)]
        public void Divide_ShouldCalculate(double a, double b, double expected) {
            double actual = Calculator.Divide(a, b);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_DivideByZero()
        {
            double a = 10;
            double b = 0;

            double expected = 0;

            double actual = Calculator.Divide(a, b);
            Assert.Equal(expected, actual);
        }
    }
}

using Xunit;
using PerDiemCalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerDiemCalculatorLib.Tests
{
    public class PerDiemProcessorTests
    {
        [Fact]
        public void CalculateFraction_ShouldReturnZero()
        {
            int hours = 0;
            int minutes = 0;

            decimal expected = 0.0M;

            decimal actual = PerDiemProcessor.CalculateFraction(hours, minutes);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(3, 5)]
        [InlineData(8, 0)]
        public void CalculateFraction_ShouldReturnOneThird(int hours, int minutes)
        {
            decimal expected = 1 / 3.0M;

            decimal actual = PerDiemProcessor.CalculateFraction(hours, minutes);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 1)]
        [InlineData(10, 33)]
        [InlineData(11, 59)]
        [InlineData(12, 0)]
        public void CalculateFraction_ShouldReturnOneHalf(int hours, int minutes)
        {
            decimal expected = 1 / 2.0M;

            decimal actual = PerDiemProcessor.CalculateFraction(hours, minutes);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 1)]
        [InlineData(15, 45)]
        [InlineData(23, 59)]
        public void CalculateFraction_ShouldReturnOne(int hours, int minutes)
        {
            decimal expected = 1.0M;

            decimal actual = PerDiemProcessor.CalculateFraction(hours, minutes);

            Assert.Equal(expected, actual);
        }
    }
}
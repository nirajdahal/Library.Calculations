using Library.Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Library.Tests
{

    //Arrange, Act, Assert
    //expected
    
    public class CalculationsTest
    {
        
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(541, 3, 544)]
        [InlineData(5,5, 10)]
        public void ShouldReturnAddedValueAsExpected(double x, double y, double expected)
        {
            //Arrange
            Calculation calc = new Calculation();

            //Act
            double actual= calc.Sum(x, y);


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

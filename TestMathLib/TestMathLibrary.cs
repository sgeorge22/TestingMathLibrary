using System;
using TestingMathLibrary;
using Xunit;

namespace TestMathLib
{
    public class TestMathLibrary 
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(6, 2, 8)]
        [InlineData(-1, 1, 0)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        public void TestAdd(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Add(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(10, 4, 6)]
        public void TestSubtract(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Subtract(i, j));
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(-20, -5, 4)]
        [InlineData(-20, 5, -4)]
        [InlineData(1, 0, 0)]
        public void TestDivision(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            if(j == 0)
            {
                Assert.ThrowsAny<DivideByZeroException>(() => mathLib.Division(i, j));
                return;
            }
            Assert.Equal(ans, mathLib.Division(i, j));
        }

        [Theory]
        [InlineData(2, 10, 20)]
        [InlineData(-8, 6, -48)]
        [InlineData(-9, -9, 81)]
        public void TestMultiply(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Multiply(i, j));
        }

       
        
    }
}

using System;

namespace TestingMathLibrary
{
    public class MathLib : IMathLibrary
    {
        public int Add(int i, int j)
        {
            return i + j;
        }

        public int Division(int i, int j)
        {
            return i / j;
        }

        public int Factorial(int i)
        {
            int result = 1;
            while (i != 1)
            {
                result = result * i;
                i = i--;
            }
            return result;
        }

        public int Modulo(int i, int j)
        {
            return i % j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Power(int i, int j)
        {
            var pow = 1;
            for(var idx = 0; idx < j; idx++)
            {
                pow *= i;
            }
            return pow;
        }

        public int Square(int i)
        {
            return i * i;
        }

        public int Subtract(int i, int j)
        {
            return i - j;
        }
    }
}

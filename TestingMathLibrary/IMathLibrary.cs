using System;
using System.Collections.Generic;
using System.Text;

namespace TestingMathLibrary
{
    interface IMathLibrary
    {
        int Add(int i, int j);
        int Subtract(int i, int j);
        int Multiply(int i, int j);
        int Division(int i, int j);
        int Power(int i, int j); //to the power of in math ir 2 to the third power
        int Square(int i);
        int Factorial(int i); //multiply all the numbers from the value input down to 2 ie 5 would be multiplied by 4, 3, 2
        int Modulo(int i, int j);
        


    }
}

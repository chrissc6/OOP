using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Muly(int x, int y)
        {
            return x * y;
        }

        public float Div(float x, float y)
        {
            return x / y;
        }

        public int FindMax(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        }

        public int Square(int x)
        {
            return x * x;
        }
    }
}

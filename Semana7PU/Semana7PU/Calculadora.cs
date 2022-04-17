using System;
using System.Collections.Generic;
using System.Text;

namespace Semana7PU
{
    public class Calculadora
    {
        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int resta(int a, int b)
        {
            return a - b;
        }

        public static int multi(int a, int b)
        {
            return a * b;
        }

        public int div(int a, int b)
        {
            if (b == 0) {
                return -1;
            }
            return a / b;
        }
    }
}

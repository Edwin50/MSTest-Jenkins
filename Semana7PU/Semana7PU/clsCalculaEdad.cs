using System;
using System.Collections.Generic;
using System.Text;

namespace Semana7PU
{
    public class clsCalculaEdad
    {
        public static int Calcular(int year) {
            return DateTime.Now.Year - year;
        }
    }
}

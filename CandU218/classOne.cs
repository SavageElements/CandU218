using System;
using System.Collections.Generic;
using System.Text;

namespace CandU218
{
    class Class1
    {
        public static int AddSeven(int X)
        {
            int M3 = X;
            int plusSEV = M3 + 7;
            return plusSEV;
        }
        public static int AddSeven(decimal y)
        {
            decimal M4 = y;
            decimal plusOcho = M4 + 8;
            return Convert.ToInt16(plusOcho);
        }

        public static int AddSeven(string z)
        {
            int M5 = Convert.ToInt16(z);
            int plusNine = M5 + 9;
            return plusNine;
        }
    }
}

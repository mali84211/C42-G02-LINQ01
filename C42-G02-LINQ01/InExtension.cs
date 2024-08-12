using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_LINQ01
{
    internal static class InExtension
    {
        public static int Reverse<T>(this T number)where T :IComparable {

            int Reversdnumber = 0, LastDigit;

            while (number > 0) {
                LastDigit = number % 10;
                Reversdnumber = Reversdnumber*10 + LastDigit;
                number = number / 10;
            }
            return Reversdnumber;
        }
    }
}

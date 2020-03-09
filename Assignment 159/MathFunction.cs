using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_159
{
    public class MathFunction
    {
        public int mathOne(int num1)
        {
            int num2 = 5;
            var Total = num1 * num2;
            return Total;
        }

        public int mathOne(decimal num1)
        {
            decimal num2 = 2.00m;
            var answer = Convert.ToInt32(num1 / num2);
            return answer;
        }

        public int mathOne(string stringOne)
        {
            int num3 = 12;
            int num4 = Convert.ToInt32(stringOne);
            int conclusion = num4 - num3;
            return conclusion;
        }
    }
}

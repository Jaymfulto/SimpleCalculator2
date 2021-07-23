using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator2
{
    public class AddOrSubtract
    {
        public static int Calculate(int argFirstNumber, int argSecondNumber)
        {
            int result = 0;
            if (argFirstNumber <= argSecondNumber)
            {
                result = argFirstNumber + argSecondNumber;

            }
            else if (argFirstNumber > argSecondNumber)
            {
                result = argFirstNumber - argSecondNumber;
            }
            return result;

        }
    }
}

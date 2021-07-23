using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator2
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string input)
        {
            double convertedInput;
            if (!double.TryParse(input, out convertedInput))
                throw new ArgumentException("Expected a numeric value");
            return convertedInput;
        }
    }
}

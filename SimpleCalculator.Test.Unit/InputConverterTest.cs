using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator2;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "gfh";
            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);
            
        }
    }
}

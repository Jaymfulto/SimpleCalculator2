using System;

namespace SimpleCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Welcome to the simple calculator program");
                Console.WriteLine("Please enter the first number");
                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                Console.WriteLine("Please enter the operation you would like to preform");
                string operation = Console.ReadLine();
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                //In real world this would be logged
                Console.WriteLine($"Please see error message. {ex.Message}");
            }


        }
    }
}

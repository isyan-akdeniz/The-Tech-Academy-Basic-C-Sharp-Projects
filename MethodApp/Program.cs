using System;

namespace MethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the PerformOperation method, passing in two numbers
            mathOperations.PerformOperation(12, 10);

            // Call the PerformOperation method again, specifying the parameters by name
            mathOperations.PerformOperation(num1: 2, num2: 3);

            // Keep the console window open to see the results
            Console.ReadLine();
        }
    }
}

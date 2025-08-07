using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0, num2 = 0;
            char op = ' ';
            bool isValid;

            //get first number
            do
            {
                Console.Write("Enter first number: ");
                isValid = float.TryParse(Console.ReadLine(), out num1);
                if (!isValid)
                {
                    Console.WriteLine("Invalid number. Enter a valid float value.");
                }
            } while (!isValid);
            //get operator
            do
            {
                Console.Write("Enter operation (+, -, *, /): ");
                isValid = char.TryParse(Console.ReadLine(), out op) &&
                          (op == '+' || op == '-' || op == '*' || op == '/');
                if (!isValid)
                {
                    Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                }
            } while (!isValid);

            // Get second number with zero check for division
            do
            {
                Console.Write("Enter second number: ");
                isValid = float.TryParse(Console.ReadLine(), out num2);

                if (!isValid)
                {
                    Console.WriteLine("Invalid number. Please enter a valid float value.");
                }
                else if (op == '/' && num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
                    isValid = false;
                }
            } while (!isValid);

            // Calculate result
            float result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            // Display result
            Console.WriteLine($"\nThe result is: {result}");
        }
    }
}

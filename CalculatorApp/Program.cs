using System;
using System.Linq;
using System.Net;

namespace CalculatorApp
{
    public class Program
    {

        public static double GetValidNum()
        {   
            string input = Console.ReadLine() ?? string.Empty;
            double x;
            while (!Double.TryParse(input, out x))
            {
                Console.WriteLine("Please enter proper number");
                input = Console.ReadLine() ?? string.Empty;
            }
            return x;
        }

        public static int Factorial(int x)
        {
            int value = 1;
            for (int i = 2; i < x + 1; i++)
            {
                value *= i;
            }
            return value;
        }

        public static object[] GetInput()
        {

            object[] user_input = new object[3];
            string valid_signs = "+-*/%^!";

            for (int i=0;i<2;i++)
            {
                Console.WriteLine($"Num {i+1}:");
                user_input[i] = GetValidNum();
            }

            Console.WriteLine("Sign: ");
            string sign = Console.ReadLine() ?? string.Empty;
            while (sign == "" || !valid_signs.Contains(sign) || sign.Length > 1)
            {
                Console.WriteLine("Please add proper sign (+, -, /, *, %)");
                sign = Console.ReadLine() ?? string.Empty;
            }
            user_input[2] = sign;

            while (sign == "/" && Convert.ToDouble(user_input[1]) == 0)
            {
                Console.WriteLine("You cannot divide by 0, please enter second number again");
                user_input[1] = GetValidNum();
            }

            return user_input;
        }

        public static double DoMath(object[] values)
        {
            double a = Convert.ToDouble(values[0]); // Convert the first value to float
            double b = Convert.ToDouble(values[1]); // Convert the second value to float
            string ch = values[2] as string ?? string.Empty; // Safely cast the operator to string
            


            switch (ch)
            {
                case "+":
                    return a+b;
                case "-":
                    return a-b;
                case "*":
                    return a*b;
                case "/":
                    return a / b;
                case "%":
                    return a % b;
                case "^":
                    return Math.Pow(a, b);
                case "!":
                    int x = Convert.ToInt32(a);
                    return Factorial(x);
                default:
                    break;
            }
            
            return 0;

        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my calculator application!");
            Console.WriteLine("Enter 2 numbers, each line will be a separate number.\n In last line enter the sign. \nCurrently available operations are: + | - | * | / | % | ^ | !");
            
            do
            {
                object[] values = GetInput();
                double output = DoMath(values);
                Console.WriteLine(output);
                Console.WriteLine("Do you want calculate something else? (y/n)");
            }
            while (Console.ReadLine() == "y");

        }
    }
}
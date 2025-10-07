using System;

namespace Assignment
{
    internal class Calculator
    {
        public static void calculate()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator:");
            string op = Console.ReadLine();

            int result;

            switch (op)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("Result is: " + result);
                    break;


                case "-":
                    result = a - b;
                    Console.WriteLine("Result is: " + result);
                    break;


                case "*":
                    result = a * b;
                    Console.WriteLine("Result is: " + result);
                    break;


                case "/":
                    result = a / b;
                    if (b != 0)
                    {
                        Console.WriteLine("Result is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Devision by Zero is not Allowed!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operater!");
                    break;

            }
        }

    }
}
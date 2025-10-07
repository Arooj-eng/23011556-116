using System;

namespace Assignment
{
    internal class factorial
    {
        public static void Fact()
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of " + n + " = " + f);
        }
    }
}
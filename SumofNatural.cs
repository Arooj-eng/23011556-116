using System;

namespace Assignment
{
    internal class SumofNaturalNo
    {
        public static void Sum()
        {
            Console.WriteLine("Enter nummbers To calculate their sum:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum is =" + sum);

        }
    }
}
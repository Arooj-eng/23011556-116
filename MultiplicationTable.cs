using System;

namespace Assignment
{
    internal class MultiplicationTable
    {
        public static void Table()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int res;

            for (int i = 1; i <= 10; i++)
            {
                res = n * i;
                Console.WriteLine(n + "*" + i + "=" + res);
            }
        }
    }
}
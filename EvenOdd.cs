using System;

namespace Assignment
{
    internal class EvenOdd
    {
        public static void evenodd()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Nnumber");
            }
        }
    }
}
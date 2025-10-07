using System;

namespace Assignment
{
    internal class CountEvenOdd
    {
        public static void Counting()
        {
            int[] a = new int[10];
            int i;
            int Evencount = 0;
            int Oddcount = 0;
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < a.Length; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Evencount++;
                }
                else
                {
                    Oddcount++;
                }
            }
            Console.WriteLine("Even elements = " + Evencount);
            Console.WriteLine("odd elements = " + Oddcount);





        }
    }
}
using System;

namespace Assignment
{
    internal class Search
    {
        public static void check()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int i;

            for (i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("Enter a Number :");
            int n = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (i = 0; i < arr.Length; i++)
                if (arr[i] == n)
                {
                    found = true;
                    break;
                }
            if (found)
            {
                Console.WriteLine("This number " + n + " exists in array:");
            }
            else
            {

                Console.WriteLine("This number " + n + " not exists in array:");
            }
        }

    }
}
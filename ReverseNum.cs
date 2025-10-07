using System;
namespace Assignment
{
    internal class Reverse
    {
        public static void Revno()
        {

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while (n > 0)
            {
                rev = (rev * 10) + (n % 10);
                n = n / 10;
            }
            Console.WriteLine("reverse = " + rev);

        }
    }
}
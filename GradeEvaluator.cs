using System;

namespace Assignment
{
    internal class grade
    {
        public static void Marks()
        {
            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());


            if (marks >= 85)
            {
                Console.WriteLine("A Grade");
            }
            else if (marks > 70 && marks < 84)
            {
                Console.WriteLine("B Grade");
            }
            else if (marks > 55 && marks < 69)
            {
                Console.WriteLine("C Grade");
            }
            else if (marks > 40 && marks < 54)
            {
                Console.WriteLine("DGrade");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
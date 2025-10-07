using System;

namespace Assignment
{
    internal class ArrayMinMax
    {
        public static void MinMax()
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Enter array elements");
            for (i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0];
            int min = arr[0];

            for (i = 0; i < arr.Length; i++)
            {
                {
                    if (max < arr[i])
                        max = arr[i];
                }

                {
                    if (min > arr[i])
                        min = arr[i];
                }

            }
            Console.WriteLine("maximum elemnt is: " + max);
            Console.WriteLine("minimum elemnt is: " + min);




        }

    }
}
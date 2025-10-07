using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nRunning EvenOdd:");
            EvenOdd.evenodd();

            Console.WriteLine("\nRunning Calculator:");
            Calculator.calculate();

            Console.WriteLine("\nRunning Grade:");
            grade.Marks();

            Console.WriteLine("\nRunning SumOfNaturalNumbers:");
            SumofNaturalNo.Sum();

            Console.WriteLine("\nRunning MultiplicationTable:");
            MultiplicationTable.Table();

            Console.WriteLine("\nRunning Factorial:");
            factorial.Fact();

            Console.WriteLine("\nRunning Reverse:");
            Reverse.Revno();
            Console.WriteLine("\nRunning ArrayMinMax:");
            ArrayMinMax.MinMax();

            Console.WriteLine("\nRunning CountEvenOdd:");
            CountEvenOdd.Counting();

            Console.WriteLine("\nRunning Search:");
            Search.check();


        }
    }
}
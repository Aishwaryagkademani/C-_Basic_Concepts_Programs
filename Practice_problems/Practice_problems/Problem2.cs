using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Practice_problems
{
    internal class Problem2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 number");
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double  sa= a * a;
            double sb= b * b;
            Console.WriteLine("square of sum of 2 numbers "+(sa + sb));

            Console.WriteLine("square of difference of 2 numbers " + (sa - sb));
        }
    }
}

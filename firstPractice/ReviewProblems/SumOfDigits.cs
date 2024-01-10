using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblems
{
    internal class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int i = num;
            int sum = 0;
            while (i != 0)
            {
                int j = i % 10;
                i = i / 10;
                sum += j;
            }
            Console.WriteLine("sum of digits of "+num+" is " + sum);
        }
    }
}

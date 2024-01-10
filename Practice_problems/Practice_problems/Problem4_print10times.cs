using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_problems
{
    internal class Problem4_print10times
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in string");
            string str=Console.ReadLine();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(str);
            }
           
        }
    }
}

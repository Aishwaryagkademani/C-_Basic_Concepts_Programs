using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class PosNeg
    {
        public void Findposneg()
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is positive");
            }
        }
    }
}

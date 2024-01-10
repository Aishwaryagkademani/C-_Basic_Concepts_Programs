using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class Prime
    {
        public void Primenumber()
        {
            Boolean flag = true;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                if(num%i==0)
                {
                    flag = false;
                    break;
                }
            }
            if(flag==true)
            {
                Console.WriteLine(num + " is prime number");
            }
            else 
            { 
                Console.WriteLine(num + " is not prime number");
            }

        }
    }
}

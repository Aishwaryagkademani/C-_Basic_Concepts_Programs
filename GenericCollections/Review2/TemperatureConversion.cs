using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
    internal class TemperatureConversion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("choose the type of temperature...\n1]Celsius to Fahrenheit\n2]Fahrenheit to celsius");
            int choice=int.Parse(Console.ReadLine());
            if(choice==1)
            {
                Console.WriteLine("Input the temperature in celsius");
                int C=int.Parse(Console.ReadLine());
                int Fdegree = (C * 9 / 5) + 32;
                Console.WriteLine("The temperature in Fahrenheit is {0}",Fdegree);
            }
            else if(choice==2)
            {
                Console.WriteLine("Input the temperature in Fahrenheit");
                int F = int.Parse(Console.ReadLine());
                int Cdegree = (F - 32)*5/9;
                Console.WriteLine("The temperature in celsius is "+ Cdegree);
            }
            else
            {
                Console.WriteLine("choose the correct input");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstPractice
{
    internal class LambdaSquraeNoAndDivisivleBy3
    {
        static void Main(string[] args)
        {
            List<int> numbers=new List<int>() {36,71,12,15,29,18,27,17,9,34};

            Console.WriteLine("The list: ");
            foreach(var value in numbers)
            {
                Console.Write("{0} ",value);
            }
            Console.WriteLine();

            var square = numbers.Select(x => x*x);

            Console.WriteLine("squares: ");
            foreach (var value in square)
            {
                Console.Write("{0}  ",value);
            }
            Console.WriteLine();

            var diviby3 = numbers.FindAll(x => (x % 3) == 0);
            Console.WriteLine("Numbers divisible by 3: ");

            foreach(var value in diviby3)
            {
                Console.Write("{0} ",value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PersonDataManagement
{
    public class LinqOnArray
    {
       public static void Main(string[] args)
        {
            int[] arr = { 20, 52, 95, 45, 32, 62, 45, 20, 30, 15, 30 };

            var distinctNo=arr.Distinct();
            foreach(int i in distinctNo)
            {
                Console.Write(i+" ");

            }

            Console.WriteLine();
            var distinctQuery=(from num in arr select  num).Distinct();
            foreach (int i in distinctQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine("numbers greater then 30:");
            var Gt30 = (from num in arr where num > 30 select num);
            foreach (int i in Gt30)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            var containElement = arr.Contains(50);
            var contains=(from no in arr select no).Contains(30);

            Console.WriteLine("conatains 50: "+containElement);
            Console.WriteLine("contains 30: "+contains);
        }
    }
}

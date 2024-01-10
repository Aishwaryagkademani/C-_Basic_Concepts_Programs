using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblems
{
    internal class Genericmethod
    {
        public static void Maximum<T>(T a,T b,T c) where T : IComparable<T>
        {
            if(a.CompareTo(b)>0) 
            {
                if(a.CompareTo(c)>0)
                {
                    Console.WriteLine(a + " is maximum");
                }
                
            }
            else if(b.CompareTo(c)>0)
            {
                Console.WriteLine(b+" is maximum");
            }
            else
            { 
                Console.WriteLine(c + " is maximum");
            }
        }
        static void Main(string[] args)
        {
            Maximum<int>(3, 5, 8);
            Maximum<string>("hello", "aaaaaa", "aru");
        }
    }
}

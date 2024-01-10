using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    internal class Stringbasics
    {
        static void Main() 
        {
            string str = "hello world";
            Console.WriteLine(str);
            string sub = str.Substring(4,3);
            Console.WriteLine($"substring start index 4 and length of substring {sub}");
            String a = "using String";
            Console.WriteLine(a);
            string b = "using string";
            Console.WriteLine(b);
            System.String c = "using system.string";
            Console.WriteLine(c);

            Demo1 ob2= new Demo1();
            ob2.show();
        }


    }
}

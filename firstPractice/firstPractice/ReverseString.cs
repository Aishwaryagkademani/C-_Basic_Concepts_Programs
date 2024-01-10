using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstPractice
{
    internal class ReverseString
    {
        static void Main()
        {
            string str = "welcome to home";
            // string str1= (string)str.Reverse();
            // Console.WriteLine(str1);
            char[] str1=str.ToCharArray();
           // char[] str2=new char[str1.Length];
            int j=str.Length-1;
            Console.WriteLine(j);
            for(int i = 0; i < str.Length; i++)
            {
                str1[j] = str[i];
                j--;

            }
            Console.WriteLine(str);
            Console.WriteLine(str1);
        }
    }
}

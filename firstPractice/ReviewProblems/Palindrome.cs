using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblems
{
    internal class Palindrome
    {
        static void Main(string[] args) {
            string str = "mulayalum";
            char[] str1 = str.ToCharArray();
            int j = 0;
            for(int i=str.Length-1; i>0; i--)
            {
                str1[i] = str[j];
                j++;
            }
            Console.WriteLine(str);
            Console.WriteLine(str1);
            string revstr = new string(str1);
            
            if (str == revstr)
            {
                Console.WriteLine(str+ " is palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not palindrome");
            }
        }
    }
}

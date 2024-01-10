using System;
using firstPractice;
namespace PubliModifierDemo
{
    internal class Program : Demo1
    {
        static void Main(string[] args)
        {
            Demo1 ob5 = new Demo1();
            ob5.show();

            Program ob6 = new Program();
            ob6.show();
        }
    }
}

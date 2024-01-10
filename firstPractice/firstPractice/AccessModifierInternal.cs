using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    public class Wait
    {
        internal void show()
        {
            Console.WriteLine("This is internal access modifier.....");
        }
    }
    internal class AccessModifierInternal : Wait
    {
        static void Main(string[] args)

        {
            Wait ob = new Wait();
            ob.show();
            AccessModifierInternal ob2= new AccessModifierInternal();
            ob2.show();
        }
    }
}

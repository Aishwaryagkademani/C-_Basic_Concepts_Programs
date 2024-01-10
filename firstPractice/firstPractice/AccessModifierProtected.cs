using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    public class Test
    {
        protected void show()
        {
            Console.WriteLine("This is protected class using inheritence.....");
        }
    }
    internal class AccessModifierProtected : Test
    {
        protected void show2()
        {
            Console.WriteLine("This is protected class within a class.....");
        }
        static void Main(string[] args)
        {
           // Test ob = new Test(); ----> Error without inheritence
           // ob.show();

            AccessModifierProtected ob = new  AccessModifierProtected();
            ob.show();
            ob.show2();

        }
    }
}

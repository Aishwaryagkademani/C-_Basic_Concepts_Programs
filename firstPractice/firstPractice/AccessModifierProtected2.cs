using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    internal class AccessModifierProtected2 : AccessModifierProtected
    {
        static void Main(string[] args)
        {
          //  Test te= new Test(); --->Error
          //  te.show();

            AccessModifierProtected2 ob = new AccessModifierProtected2();
            ob.show();
        }
    }
}

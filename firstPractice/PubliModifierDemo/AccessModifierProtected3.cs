using System;
using System.Collections.Generic;
using System.Text;
using firstPractice;
namespace AcessModifierDemo
{
    internal class AccessModifierProtected3 : Test
    {
        static void Main(string[] args)
        {
            // Test ob = new Test();----->Error without inheritence
            //ob.show();

            AccessModifierProtected3 ob = new AccessModifierProtected3();
            ob.show();
        }
    }
}

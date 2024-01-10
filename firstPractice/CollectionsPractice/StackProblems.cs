using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace CollectionsPractice
{
    internal class StackProblems
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("QR");
            stk.Push("OTP");
            stk.Push("Authentication");
            stk.Push("Biometric");
            stk.Push("Password");

            foreach(object o in stk)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Popped element is :"+stk.Pop());
            
            
        }

        
    }
}

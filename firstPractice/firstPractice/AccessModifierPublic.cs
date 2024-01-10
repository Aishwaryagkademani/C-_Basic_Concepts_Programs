using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{

    public class Demo1
    {
        public void show()
        {
            Console.WriteLine("This is public method....");
        }

        public void show2()
        {
            show();
        }

    }
    internal class AccessModifierPublic : Demo1
    {
        static void Main(string[] args)
        {
            Demo1 ob = new Demo1();
            ob.show2();

            AccessModifierPublic ob2 = new AccessModifierPublic();
            ob2.show();
        }
    }

}

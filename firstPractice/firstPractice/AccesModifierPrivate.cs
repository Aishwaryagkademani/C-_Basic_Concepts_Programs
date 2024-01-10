using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    class Demo
    {
        private void show2()
        {
            Console.WriteLine("This is private method....");
        }
    }
    internal class AccesModifierPrivate
    {
            private void show()
            {
                Console.WriteLine("This is private method....");
            }
        static void Main(string[] args)
        {
            AccesModifierPrivate ob = new AccesModifierPrivate();
            ob.show();

          //  Demo de = new Demo();---> Error
          //  de.show2();
        }

        }
    }

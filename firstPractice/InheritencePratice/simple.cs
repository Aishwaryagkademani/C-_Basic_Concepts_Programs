using System;
using System.Collections.Generic;
using System.Text;

namespace InheritencePratice
{
  public class Test1
    {
        public void Show()
        {
            Console.WriteLine("This is base class");
        }
    }
    class Test2 : Test1
    {
        public void Show2()
        {
            Console.WriteLine("This is derived class");
        }
       
    }
    internal class simple
    {
        static void Main(string[] args)
        {
            Test2 ob1 = new Test2();
            ob1.Show2();
            ob1.Show();
        }
    }
}

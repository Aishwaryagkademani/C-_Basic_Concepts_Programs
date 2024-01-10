using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismProblems
{
    public class New
    {
        public string str;
        public int num;
        public static New operator +(New ob1, New ob2)
        {
            New ob3 = new New();
            ob3.str=ob1.str+" "+ob2.str;
            ob3.num=ob1.num+ob2.num;
            return ob3;

        }
}

    internal class OperatorOverloding
    {

        static void Main(string[] args)
        {
            New ob1 = new New();
            ob1.str = "Ragunandana";
            ob1.num = 23;

            New ob2 = new New(); 
            ob2.str = "Ram";
            ob2.num = 94;

            New ob3 = new New();
            ob3 = ob1 + ob2;

            Console.WriteLine(ob3.str);
            Console.WriteLine(ob3.num);
        }

    }
}

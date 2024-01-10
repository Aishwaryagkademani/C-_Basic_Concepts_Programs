using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    public delegate void Calculation(int a, int b);
    internal class DelegatesExample
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is : {0}", result);
        }

        public static void Substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substract result is : {0}", result);
        }
        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is : {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is : {0}", result);
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(DelegatesExample.Addition);
            obj.Invoke(3, 5);
            DelegatesExample.Addition(3, 5);
            obj = Substract;
            obj.Invoke(3, 5);
            obj = Multiply;
            obj.Invoke(3, 5);
            obj = Division;
            obj.Invoke(3, 5);

        }
    }
}

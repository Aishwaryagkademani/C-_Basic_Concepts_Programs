using System;
using System.Linq;
using System.Collections;
using FileBasicOperations;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //var ab=(from t in arr where t>5 select t);
            //foreach (int i in ab)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList a= new ArrayList();
            //a.Add(1);
            //a.Add(2);
            //a.Add(3);
            //Console.WriteLine();

            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}

            FileExistOperationWithTextF ob = new FileExistOperationWithTextF();
            ob.FindFileExist();
        }
    }
}

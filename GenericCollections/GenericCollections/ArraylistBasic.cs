using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    internal class ArraylistBasic
    {
        static void Main(string[] args)
        {
            ArrayList ls = new ArrayList();
            Console.WriteLine(ls.Capacity);
            ls.Add(100);
            Console.WriteLine(ls.Capacity);
            ls.Add(200); ls.Add(300);ls.Add(400);
            Console.WriteLine(ls.Capacity);
            ls.Add(500);

            foreach(object obj in ls)
            {
                Console.Write(obj+" ");
            }
            Console.WriteLine();
            ls.Insert(2, 350);
            foreach (object obj in ls)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine() ;
            ls.Remove(200);
            foreach (object obj in ls)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine() ;
            ls.RemoveAt(2);
            foreach (object obj in ls)
            {
                Console.Write(obj + " ");
            }

        }
    }
}

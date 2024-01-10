using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    internal class HashtableBasic
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Mona");
            ht.Add("Email", "mona123@gmail.com");
            ht.Add("mno", "9586452364");

            Console.WriteLine(ht["Email"]);

            foreach(object obj in ht.Keys)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            foreach (object obj in ht.Values)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();


            foreach (object obj in ht.Keys)
            {
                Console.WriteLine(obj+" "+ht[obj]);
            }

            Console.WriteLine();

        }

    }
    
}

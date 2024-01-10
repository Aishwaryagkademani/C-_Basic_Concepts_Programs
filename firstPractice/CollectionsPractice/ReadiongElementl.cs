using System;
using System.Collections;
using System.Dynamic;
using System.Reflection.Emit;
namespace CollectionsPractice
{
    internal class ReadiongElementl
    {
        static void Main(string[] args)
        {
            ArrayList demo= new ArrayList();
            demo.Add("hello");
            demo.Add('g');
            demo.Add(0.36);
            demo.Add(78);
            demo.Add(33333333);

            foreach(object i in demo)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(  );

            for (int i=0; i<demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }

            Console.WriteLine(  );
            //insert element
            demo.Insert(2, "very Happy");
            for (int i = 0; i < demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }
            Console.WriteLine(  );
            //Removing element 4 types
            //removing element using Remove
            demo.Remove("very Happy");
            for (int i = 0; i < demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }
            Console.WriteLine(  );
            //using index value RemoveAt
            demo.RemoveAt(1);
            for (int i = 0; i < demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }           

            //removing range of elements          
            Console.WriteLine( );
            demo.RemoveRange(0, 2);
            for (int i = 0; i < demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }
            Console.WriteLine(  );
            Console.WriteLine(  " the capacity before is :"+demo.Capacity);
            //removing all elements
            demo.Clear();
            for (int i = 0; i < demo.Count; i++)
            {
                Console.WriteLine(demo[i]);
            }
            Console.WriteLine(" the capacity after is :" + demo.Capacity);

        }

    }
}

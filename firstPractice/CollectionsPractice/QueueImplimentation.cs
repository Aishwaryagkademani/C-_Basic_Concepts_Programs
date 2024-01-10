using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPractice
{
    internal class QueueImplimentation
    {
        static void Main(string[] args)
        {
            Queue<string> qu = new Queue<string>();
            qu.Enqueue("atm");
            qu.Enqueue("Cash");
            qu.Enqueue("Bank");
            qu.Enqueue("CheckBook");
            qu.Enqueue("Withdraw");

            int count=qu.Count;
            Console.WriteLine("number of elements: "+count);
            Console.WriteLine("peek element is :"+qu.Peek());

            for(int i=0; i<count; i++)
            {
                Console.WriteLine(qu.Dequeue()); 
            }
        }
    }
}

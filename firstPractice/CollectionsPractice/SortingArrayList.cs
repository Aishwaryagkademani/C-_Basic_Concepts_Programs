using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPractice
{
    internal class SortingArrayList
    {
        static void PrintVal(IEnumerable mylist)
        {
            foreach(object item in mylist)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ArrayList arr=new ArrayList();
            arr.Add("nani");
            arr.Add("priya");
            arr.Add("tina");
            arr.Add("soniya");
            arr.Add("Romani");
            arr.Add("asha");
            arr.Sort();
            PrintVal(arr);

        }
    }
}

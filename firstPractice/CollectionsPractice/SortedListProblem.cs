using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CollectionsPractice
{
    internal class SortedListProblem
    {
        static void Main(string[] args)
        {
            SortedList sl= new SortedList();
            sl.Add("wc", "welcome");
            sl.Add("wau", "What about you");
            sl.Add("u", "you");
            sl.Add("r", "are");

            foreach (DictionaryEntry s in sl)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }

            Console.WriteLine("Abrivation of what about you containg :" + sl.ContainsKey("wau"));
            Console.WriteLine("full form of wt containg :" + sl.ContainsKey("wt"));

            sl.Remove("u");

            foreach (DictionaryEntry s in sl)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }

            Console.WriteLine( "capacity::"  +sl.Capacity   );
            Console.WriteLine(  "count :: "+sl.Count);

            Console.WriteLine(  "index of r is "+sl.IndexOfKey("r"));
            Console.WriteLine("index of wau is " + sl.IndexOfKey("wau"));

            sl.Clear();
            foreach (DictionaryEntry s in sl)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }

        }
    }
}

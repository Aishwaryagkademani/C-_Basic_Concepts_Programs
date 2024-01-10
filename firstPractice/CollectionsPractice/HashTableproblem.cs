using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CollectionsPractice
{
    internal class HashTableproblem
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("wc", "welcome");
            ht.Add("wau", "What about you");
            ht.Add("u", "you");
            ht.Add("r", "are");

            foreach (DictionaryEntry s in ht) 
            {
                Console.WriteLine(s.Key+" "+s.Value);
            }

            ht.Remove("u");
            foreach (DictionaryEntry s in ht)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }
           

        }
       
    }
}

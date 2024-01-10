using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace GenericCollections
{
    internal class Listexample
    {
        public int id { get; set; }
        public string name { get; set; }
        static void Main(string[] args)
        {
            //List<int> intElements=new List<int>();
            //intElements.Add(58);
            //intElements.Add(95);
            //intElements.Add(75);
            //List<int> list2=new List<int>();
            //list2.Add(57);
            //list2.Add(65);
            //intElements.AddRange(list2);

            //foreach(int i in intElements)
            //{
            //    Console.WriteLine(i);
            //}

            //Queue <string> qu=new Queue <string> ();
            //qu.Enqueue("rema");
            //qu.Enqueue("mamata");
            //qu.Enqueue("Aman");
            //qu.Enqueue("Yamini");
            //qu.Enqueue("Basu");

            //foreach(string s in qu)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine();
            ////Console.WriteLine(qu.Count);

            //var lambdaDemo1 = qu.Select(x =>x.StartsWith('r'));
            //foreach (var ab in lambdaDemo1)
            //{
            //    Console.WriteLine(ab);
            //}

            //Console.WriteLine();
            //var lambdaDemo2 = qu.Select(x => x.Substring(0,2)).ToList();
            //foreach(var ab in lambdaDemo2)
            //{
            //    Console.WriteLine(ab);
            //}

            List<Listexample> list = new List<Listexample>()
            {
                new Listexample{id=8,name="maona"},
                new Listexample{id=9,name="shantan"},
                new Listexample{id=10,name="kanishka"},
                new Listexample{id=11,name="savitri"},
                new Listexample{id=11,name="rosalia"},
                new Listexample{id=8,name="yuva" },
                new Listexample{id=14,name="asha"}
            };

            //var OrderList=list.OrderBy(x => x.name);
            //foreach (var ab in OrderList)
            //{
            //    Console.WriteLine("id={0} name={1}",ab.id,ab.name);
            //}

            //LINQ PRACTICE

            var a=list.ToList();
            Console.WriteLine(a);
            foreach (var ab in a)
            {
                Console.WriteLine("id={0} name={1}", ab.id, ab.name);
            }
            Console.WriteLine();
            Console.WriteLine();
            var b = (from ab in list where ab.id < 12 select ab);
            foreach (var ab in b)
            {
                Console.WriteLine("id={0} name={1}", ab.id, ab.name);
            }

            Console.WriteLine();
            Console.WriteLine();
            var c = list.Distinct().ToList();
            foreach (var ab in c)
            {
                Console.WriteLine("id={0}", ab);
            }

            Console.WriteLine();
            var d=(from abc in list  select abc).Distinct();
            foreach (var ab in d)
            {
                Console.WriteLine("id={0} name={1}", ab.id, ab.name);
            }

        }
    }
}

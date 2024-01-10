using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace firstPractice
{
    abstract class Example
    {
        abstract public int id { get; set; }
        abstract public string name { get; set; }
    }

    class Ring : Example
    {
        int studid;
        string studName;
        override public int id
        {
            set
            {
                this.studid = value;
            }

            get
            {
                return this.studid;
            }
        }
            override public string name
        {
            set
            {
                this.studName = value;
            }

            get
            {
                return this.studName;
            }
        }


        }
    internal class AbstractPropertiesExample
    {
        static void Main(string[] args)
        {
            Ring r = new Ring();
            r.id = 15;
            r.name= "Rama";

            Console.WriteLine(r.id);
            Console.WriteLine(r.name);
        }
    }
}

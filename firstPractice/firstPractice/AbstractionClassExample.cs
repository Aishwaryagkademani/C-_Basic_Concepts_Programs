using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    abstract class Person
    {
        public string fname;
        public string lname;
        public int age;
        public long phoneno;
        public abstract void show();

    }

    class Student1 : Person
    {
        public int rollno;
        public int fees;

        public override void show()
        {
            string name=this.fname+" "+this.lname;
            Console.WriteLine("student name is {0}",name);
            Console.WriteLine("student age is {0}", this.age);
            Console.WriteLine("student Phone no is {0}", this.phoneno);
            Console.WriteLine("student roll no is {0}", this.rollno);
            Console.WriteLine("student fees is {0}", this.fees);
        }
    }

    class Teacher : Person
    {
        public string qualification;
        public int salary;
        public override void show()
        {

            string name = this.fname + " " + this.lname;
            Console.WriteLine("teacher name is {0}", name);
            Console.WriteLine("teacher age is {0}", this.age);
            Console.WriteLine("teacher Phone no is {0}", this.phoneno);
            Console.WriteLine("teacher qalification is {0}", this.qualification);
            Console.WriteLine("teacher salary is {0}", this.salary);
        
    }
    }
    internal class AbstractionClassExample
    {
        static void Main(string[] args)
        {
            Student1 ana = new Student1();
            ana.fname = "nani";
            ana.lname = "patil";
            ana.age = 25;
            ana.phoneno = 2549686732;
            ana.fees = 40000;
            ana.rollno = 13;

            ana.show();
        }
    }
}

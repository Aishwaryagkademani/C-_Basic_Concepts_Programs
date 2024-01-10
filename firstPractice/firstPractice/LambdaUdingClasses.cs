using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace firstPractice
{
    class Student
    {
        public  int roolNo { get; set; }
        public string name { get; set; }
    }
    internal class LambdaUdingClasses
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{roolNo=1,name="Manan"},
                new Student{roolNo=2,name="Laxmi"},
                new Student{roolNo=3,name="Vamana"},
                new Student{roolNo=4,name="sakshi"}
            };

            var newdetails = list.OrderBy( x=> x.name);

            foreach(var stud in newdetails)
            {
                Console.WriteLine("roll no;"+stud.roolNo+"  Name : "+stud.name);
            }

            Console.WriteLine("...................*********...................");

            //var add = (int a, int b) => a + b;
            
            //int x=add(3,5);
            //Console.WriteLine(x);
            //{
            //    int sum = a + b;
            //    return sum;
            //};
        }
    }
}

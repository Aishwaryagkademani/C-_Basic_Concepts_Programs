using System;
using System.Collections.Generic;
using System.Text;

namespace InheritencePratice
{
  

        public class Employee
        {
            public string Eid;
            public string Name;
            public int perhrSal = 400;
            public void Show()
            {
                Console.WriteLine("Employee Id : " + Eid);
                Console.WriteLine("Employee Name : " + Name);
            }
        }

        class PartTime : Employee
        {
            public void Displaysal()
            {

                Console.WriteLine("Enter no of hours worked");
                int noHours = int.Parse(Console.ReadLine());
                Show();
                Console.WriteLine("Total salary : " + (noHours * perhrSal));
            }


        }
    class FulTime
    {
        int days;
    }
    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {

            PartTime ob = new PartTime();
            Console.WriteLine("Enter Employee id");
            ob.Eid = Console.ReadLine();
            Console.WriteLine("Enter Employee name");
            ob.Name = Console.ReadLine();
            ob.Displaysal();
        }
       
    }
}

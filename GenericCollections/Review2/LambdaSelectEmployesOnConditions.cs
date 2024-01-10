using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace Review2
{
    class Employee
    {
       // public int Eid { get; set; }
        public string EName { get; set; }
        public int salary { get; set; }

        //public static Employee EmpDetails()
        //{
        //    List<Employee> Elist = new List<Employee>()
        //    {
        //        new Employee{EName="suresh",salary=20000 },
        //        new Employee{EName="suresh",salary=30000 },
        //        new Employee{EName="suresh",salary=45000 },
        //        new Employee{EName="suresh",salary=25000 },
        //        new Employee{EName="suresh",salary=33000 },
        //        new Employee{EName="suresh",salary=40000 }
        //    };
        //    return Elist;
        //}
    }
    internal class LambdaSelectEmployesOnConditions
    {
        static void Main(string[] args)
        {
            List<Employee> Elist = new List<Employee>()
            {
                new Employee{EName="suresh",salary=20000 },
                new Employee{EName="Rama",salary=30000 },
                new Employee{EName="Ragav",salary=45000 },
                new Employee{EName="Kavita",salary=25000 },
                new Employee{EName="Mahalaxmi",salary=33000 },
                new Employee{EName="Tanaya",salary=40000 }
            };

            Console.WriteLine("Employee Details are .......");
            foreach (var emp in Elist)
            {
                Console.WriteLine("emplyee name= {0}  Employee Salary=  {1}", emp.EName, emp.salary);
            }

            // var salaryGt30000 = Elist.Select(x => x.salary>30000);
            var salGt = (from emp in Elist where emp.salary > 25000 select emp);
            Console.WriteLine("Employees who are having salay greater then 30000 are......");
            foreach(var emp in salGt)
            {
                Console.WriteLine("emplyee name= {0}  Employee Salary=  {1}",emp.EName,emp.salary);
            }

            Console.WriteLine();
            Console.WriteLine();
            var startsWith = Elist.FindAll(x => x.EName.StartsWith('R')).ToList();
            foreach (var emp in startsWith)
            {
                Console.WriteLine("emplyee name= {0} ", emp.EName);
            }
        }
    }
}

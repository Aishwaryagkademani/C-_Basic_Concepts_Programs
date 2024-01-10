using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PersonDataManagement
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public string department { get; set; }
        

        public static List<Employee> EmpDetails()
        {
            List<Employee> listemp = new List<Employee>()
            {
                new Employee{id=11,Name="Shravan",salary=10000,department="IT"},
                new Employee{id=22,Name="Parvati",salary=52444,department="sales"},
                new Employee{id=33,Name="yuktha",salary=25200,department="IT"},
                new Employee{id=44,Name="shravani",salary=30000,department="IT"},                
                new Employee{id=55,Name="govind",salary=15000,department="IT"},
                new Employee{id=66,Name="Ravi",salary=40000,department="IT"},
                new Employee{id=77,Name="Umashri",salary=42000,department="sales"},
                new Employee{id=88,Name="Manan",salary=15000,department="IT"}
            };
            return listemp;
        }

        public static void Main(string[] args)
        {
            //using method syntax
            var MethodSyntax = Employee.EmpDetails();
            foreach(var emp in MethodSyntax)
            {
                Console.WriteLine($"id={ emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            //using query syntax
            var QuerySyntax=(from emp in Employee.EmpDetails() select emp).ToList();

            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            var salaryGTMethod = EmpDetails().Where(whr=>whr.salary> 30000).ToList();
            Console.WriteLine("Employee details whose salary is greater then 30000 is ");
            Console.WriteLine();
            foreach (var emp in salaryGTMethod)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Employee details whose salary is greater then 20000 is ");
            Console.WriteLine();
            var salaryGtQuery =(from emp in Employee.EmpDetails() where emp.salary > 20000 select emp).ToList();
            foreach (var emp in salaryGtQuery)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("the member who belongs to sales dempartment are:");
            var depMember = EmpDetails().Where(whr=> whr.department == "sales").ToList();
            foreach (var emp in depMember)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("the member who belongs to IT dempartment are:");
            var depMemberQuery =(from emp in Employee.EmpDetails() where emp.department=="IT" select emp).ToList();

            foreach (var emp in depMemberQuery)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            Console.WriteLine();
            Console.WriteLine();
            var distictDept = EmpDetails().Distinct();
            foreach (var emp in distictDept) 
            {
                Console.WriteLine($"id={emp.id} name={emp.Name} salary={emp.salary} department={emp.department}");
            }

            var containsS = EmpDetails().Where(whr => whr.Name.Contains('s'));
            foreach (var emp in containsS)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name}");
            }
            Console.WriteLine();
            Console.WriteLine();
            var containsQuery = (from emp in Employee.EmpDetails() where emp.Name.Contains('t') select emp);
            foreach (var emp in containsQuery)
            {
                Console.WriteLine($"id={emp.id} name={emp.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("first element:");
            var firstElement = EmpDetails().First();
            Console.WriteLine(firstElement.Name );

            Console.WriteLine("first element:");
            var fisrtQuery = (from emp in Employee.EmpDetails() select emp).First();
            Console.WriteLine(fisrtQuery.Name);

            var salaryGT = EmpDetails().All(whr => whr.salary > 10000);
            Console.WriteLine("All employees salary is greater then 10000 : "+salaryGT);

            Console.WriteLine();
            var salaryQueryAll = (from emp in EmpDetails() select emp.salary).All(x => x > 9000);
            Console.WriteLine("All employees salary is greater then 9000 : " + salaryQueryAll);


        }
    }
}

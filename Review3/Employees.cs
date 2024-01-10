using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace Review3
{
    internal class Employees
    {
        public  string Ename { get; set; }
        public  string Edept { get; set; }
        public  DateTime EjoinDate { get; set; }

        public static void FilterEmployees()
        {
            List<Employees> employeesList = new List<Employees>()
            {
                new Employees() {Ename="Rama",Edept="Test",EjoinDate=new DateTime(2023,6,23)},
                new Employees() {Ename="Geetha",Edept="Test",EjoinDate=new DateTime(2022,5,14)},
                new Employees() {Ename="Uma",Edept="Sales",EjoinDate=new DateTime(2023,7,20)},
                new Employees() {Ename="Mahima",Edept="Sales",EjoinDate=new DateTime(2023,3,30)},
                new Employees() {Ename="Triveni",Edept="Test",EjoinDate=new DateTime(2022,7,5)},
                new Employees() {Ename="Esha",Edept="Sales",EjoinDate=new DateTime(2023,11,1)},
                new Employees() {Ename="Ragini",Edept="Sales",EjoinDate=new DateTime(2023,5,15)},
                new Employees() {Ename="Jyothi",Edept="Test",EjoinDate=new DateTime(2023,12,11)},
                new Employees() {Ename="Amar",Edept="Sales",EjoinDate=new DateTime(2023,9,8)},

            };

            Console.WriteLine("Original List of Employees is ........");
            foreach (var emp in employeesList)
            {
                Console.WriteLine("Employee name= {0}  Department= {1}  Joining Date= {2}", emp.Ename, emp.Edept, emp.EjoinDate);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Employees List who joined in last 6 months to the sales department.......");
            var today=DateTime.Today;
            var empBefor6MonthsSales = employeesList.Where(x => x.EjoinDate > new DateTime(today.Year,today.Month-6,today.Day) && x.Edept=="Sales").ToList();
            foreach(var emp in empBefor6MonthsSales)
            {
                Console.WriteLine("Employee name= {0}  Department= {1}  Joining Date= {2}",emp.Ename,emp.Edept,emp.EjoinDate);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Employees List who joined in last 6 months to the test department.......");
           // var today = DateTime.Today;
            var empBefor6MonthsTest = employeesList.Where(x => x.EjoinDate > new DateTime(today.Year, today.Month - 6, today.Day) && x.Edept == "Test").ToList();
            foreach (var emp in empBefor6MonthsTest)
            {
                Console.WriteLine("Employee name= {0}  Department= {1}  Joining Date= {2}", emp.Ename, emp.Edept, emp.EjoinDate);
            }
        }
    }
}

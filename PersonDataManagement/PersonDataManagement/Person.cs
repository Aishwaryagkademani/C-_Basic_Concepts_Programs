using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.ComponentModel;
namespace PersonDataManagement
{
    public class Person
    {
        public int ssn { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }


        static void Main(string[] args)
        {
            //uc 1 -create person class with ssn, name, address and age fields
            //     -CreateInstanceBinder variable for List of personclass in Main Method
            //     -AddingNewEventArgs default values in created list
            Console.WriteLine("use case 1: ");
            List<Person> listPerson = new List<Person>()
            {
                new Person{ssn=11,Name="Manansa",Address="Govindapura",Age=10},
                new Person{ssn=22,Name="Rani",Address="Chikodi",Age=15},
                new Person{ssn=33,Name="Varun",Address="Habanati",Age=14},
                new Person{ssn=44,Name="Manansa",Address="Yellurghard",Age=85},
                new Person{ssn=55,Name="Vanishri",Address="Lokapur",Age=20},
                new Person{ssn=66,Name="Vedhavathi",Address="Tara nagar",Age=70}
            };


            foreach (var item in listPerson)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }
            Console.WriteLine();


            //uc2 = Retrieve top 2 records from the list for age is less than 60
            Console.WriteLine("use case 2: ");
            var Top2Records = listPerson.Where(whr=>whr.Age>60).Take(2);

            foreach (var item in Top2Records)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }
            Console.WriteLine();
            
            //uc3 = Retrieve all record from the list for age between 13 to 18
            Console.WriteLine("use case 3: ");
            var retriveBetween = listPerson.Where(whr => whr.Age > 13 && whr.Age < 18);
            foreach (var item in retriveBetween)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }
            Console.WriteLine();

            //uc4 = Retrive average age of the list
            Console.WriteLine("use case 4: ");
            var AverageAge=(from p in listPerson select  p.Age).Average();
            Console.WriteLine("Average age of list is :"+AverageAge);

            Console.WriteLine();
            //uc5 = check for specific name present in the list or not
            Console.WriteLine("use case 5: ");
            var specificName1 = (from p in listPerson select p.Name).Contains("soniya");
            var specificName2 = (from p in listPerson select p.Name).Contains("Rani");
            Console.WriteLine("list contains name soniya : "+specificName1);
            Console.WriteLine("list contains name Rani : " + specificName2);

            Console.WriteLine();
            //uc6 = Skip record from the list for age is less than 60
            Console.WriteLine("use case 6: ");
            //var skiprecord = listPerson.Where(wh => wh.Age<60).ToList();
            //Console.WriteLine("greater should be printed");
            //foreach (var item in skiprecord)
            //{
            //    Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            //}

            Console.WriteLine();
            var skiprecord2=(from per in listPerson select per ).SkipWhile(per=> per.Age<60).ToList();
            foreach (var item in skiprecord2)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }


            Console.WriteLine();
            //uc7 = Remove specific name from the list
            Console.WriteLine("use case 7 : ");

             listPerson= listPerson.Where (p => p.Name != "Rani").ToList();
            Console.WriteLine("removed Rani's record");
            foreach (var item in listPerson)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("removed varun's record");

            listPerson = listPerson.Where(p => p.Name != "Varun").ToList();
            foreach (var item in listPerson)
            {
                Console.WriteLine($"SSN={item.ssn} Name={item.Name} Address={item.Address} Age={item.Age}");
            }
        }
    }
}

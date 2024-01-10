using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace JsonFilehandlingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerName = "John",
                    Age=33,
                    Email="john12@gmail.com",
                    TotalSales=40000,
                    FinalPurchaseDate=new DateTime(2021,3,29)
                },
                new Customer
                {
                    CustomerName = "George",
                    Age=45,
                    Email="gorge34@gmail.com",
                    TotalSales=6000,
                    FinalPurchaseDate=new DateTime(2021,2,12)
                },
                new Customer
                {
                    CustomerName = "Peter",
                    Age=32,
                    Email="peter@gmail.com",
                    TotalSales=2000,
                    FinalPurchaseDate=new DateTime(2021,1,10)
                }
            };

            var customer1 = new Customer
            {
                CustomerName = "Harsha",
                Age = 32,
                Email = "Harsha@gmail.com",
                TotalSales = 1900,
                FinalPurchaseDate = new DateTime(2021, 2, 5)

            };


            var customerJson = JsonConvert.SerializeObject(customers);
            //Console.WriteLine(customerJson);
            

            //var customerJson2 =JsonConvert.SerializeObject(customer1);
            //Console.WriteLine(customerJson2);




            //var jsonString = "[{\"CustomerName\":\"John\",\"Email\":\"john12@gmail.com\",\"Age\":33,\"TotalSales\":40000.0,\"FinalPurchaseDate\":\"2021-03-29T00:00:00\"},{\"CustomerName\":\"George\",\"Email\":\"gorge34@gmail.com\",\"Age\":45,\"TotalSales\":6000.0,\"FinalPurchaseDate\":\"2021-02-12T00:00:00\"},{\"CustomerName\":\"Peter\",\"Email\":\"peter@gmail.com\",\"Age\":32,\"TotalSales\":2000.0,\"FinalPurchaseDate\":\"2021-01-10T00:00:00\"}]";
            var customerList2 = JsonConvert.DeserializeObject<List<Customer>>(customerJson);
        
            foreach(var i in customerList2)
            {
                Console.WriteLine(i.CustomerName,i.Age,i.Email,i.FinalPurchaseDate,i.TotalSales);
            }

        }

        [Serializable]
        private class Customer
        {
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public decimal TotalSales {  get; set; }
            public DateTime FinalPurchaseDate { get; set; } 
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Review2
{
    class Customer
    {
        public string Name { get; set; }
        public int Cid { get; set; }
    }

    class Order
    {
        public int Cid { get; set; }
        public string product { get; set; }
        public int Price { get; set; }
    }
    internal class JoinCollectionsCustomersOrders
    {
        static void Main(string[] args)
        {
            List<Customer> custlist = new List<Customer>()
            {
                new Customer{Name="Arun",Cid=2},
                new Customer{Name="Rama",Cid=8},
                new Customer{Name="uma",Cid=7},
                new Customer{Name="sunita",Cid=6},
                new Customer{Name="sweta",Cid=3}
            };
            //customer.Add("");
            //customer.Add("");
            //customer.Add("");
            //customer.Add("");
            //customer.Add("");
            //customer.Add("Jyothi");
            //customer.Add("umesh");

            Console.WriteLine("customer info list........");
            foreach(var item in custlist)
            {
                Console.WriteLine("Name= {0} customerId= {1} ",item.Name,item.Cid);
            }

            Console.WriteLine();
            Console.WriteLine();
            List<Order> orderlist = new List<Order>()
            {
                new Order{Cid=8,product="maggie",Price=10},
                new Order{Cid=6,product="Ragi",Price=50},
                new Order{Cid=2,product="oil",Price=80},
                new Order{Cid=7,product="sonpapad",Price=40},
                new Order{Cid=3,product="grains",Price=90}
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ordered product list ........");
            foreach (var item in orderlist)
            {
                Console.WriteLine("Product= {0} price= {1} customerId= {2}", item.product,item.Price, item.Cid);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("combined List of customer info and their order info.......");
            var combinedList=(from cust in custlist join order in orderlist on cust.Cid equals order.Cid select new {cust.Name,cust.Cid,order.product,order.Price}).ToList();
            foreach (var item in combinedList)
            {
                Console.WriteLine("customer Name= {0} customerId= {1} Product= {2} price= {3} ", item.Name ,item.Cid,item.product, item.Price);
            }
        }
    }
}

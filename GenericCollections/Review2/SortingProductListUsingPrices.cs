using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Review2
{
    class Product
    {
        public string product { get; set; }
        public int Price { get; set; }
    }
    internal class SortingProductListUsingPrices
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>()
            {
                new Product{product="maggie",Price=10},
                new Product{product="Ragi",Price=50},
                new Product{product="oil",Price=80},
                new Product{product="sonpapad",Price=40},
                new Product{product="grains",Price=90}
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("product list ........");
            foreach (var item in ProductList)
            {
                Console.WriteLine("Product= {0} price= {1}", item.product, item.Price);
            }
            Console.WriteLine();
            Console.WriteLine();

            var sortedList=ProductList.OrderBy(x => x.Price).ToList();
            Console.WriteLine("sorted product list based on Prices........");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Product= {0} price= {1}", item.product, item.Price);
            }
        }
    }
}

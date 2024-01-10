using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace Review2
{
    internal class MovieTicketPriceCalculation
    {
       // double price;
        public static int child = 100, adults = 400, seniors = 350;
        public static double PriceCalculation(int age,double discount)
        {
            if (age == 1)
            {
               double mo = child * discount;
                double price=child-mo;
                return price;
            }
            else if(age == 2)
            {
                double mo = adults * discount;
                double price = adults - mo;
                return price;
            }
            else if (age == 3)
            {
                double mo = seniors * discount;
                double price = seniors - mo;
                return price;
            }
            else
            {
                Console.WriteLine("enter the correct input");
                return -1;
            }

        }
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to ticket price calculation ...........");
            Console.WriteLine();
            Console.WriteLine("choose the movie timings\n1]Morning\n2]Afternoon\n3]Evening\n4]Night:");
            int timings =int.Parse( Console.ReadLine());

            if( timings == 1 ) 
            {
                double discount = 0.1;
                Console.WriteLine("10% Discount will be provided");
                Console.WriteLine("choose the age of a person\n1]under 12\n2]adults(12-64)\n3]seniors(65+)");
                int age=int.Parse( Console.ReadLine());
                double Price = PriceCalculation(age, discount);
                Console.WriteLine("Ticket price is: {0}",Price);
            }
            else if (timings == 2)
            {
                double discount = 0.05;
                Console.WriteLine("5% Discount will be provided");
                Console.WriteLine("choose the age of a person\n1]under 12\n2]adults(12-64)\n3]seniors(65+)");
                int age = int.Parse(Console.ReadLine());
                double Price = PriceCalculation(age, discount);
                Console.WriteLine("Ticket price is: {0}", Price);
            }
            else if (timings == 3)
            {
                double discount = 0.02;
                Console.WriteLine("2% Discount will be provided");
                Console.WriteLine("choose the age of a person\n1]under 12\n2]adults(12-64)\n3]seniors(65+)");
                int age = int.Parse(Console.ReadLine());
                double Price = PriceCalculation(age, discount);
                Console.WriteLine("Ticket price is: {0}", Price);
            }
            else if (timings == 4)
            {
                double discount = 0.0;
                Console.WriteLine("No Discount will be provided");
                Console.WriteLine("choose the age of a person\n1]under 12\n2]adults(12-64)\n3]seniors(65+)");
                int age = int.Parse(Console.ReadLine());
                double Price = PriceCalculation(age, discount);
                Console.WriteLine("Ticket price is: {0}", Price);
            }
            else
            {
                Console.WriteLine("Input the correct value");
            }

        }
    }
}

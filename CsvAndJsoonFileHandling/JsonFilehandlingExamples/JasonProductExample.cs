using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
namespace JsonFilehandlingExamples
{
    public class Pdetails
    {
        public string product { get; set; }
        public double price { get; set; }
    }
    internal class JasonProductExample
    {
      public static void Main(string[] args)
        {
            Pdetails pd=new Pdetails();
            pd.product = "Rice";
            pd.price = 100;

            string jsonstring = JsonSerializer.Serialize(pd);
            Console.WriteLine(jsonstring);
            string productDetails = @"D:\\visual studio C# projects\\CsvAndJsoonFileHandling\\JsonFilehandlingExamples\ProductDetails.json";
            File.WriteAllText(productDetails, jsonstring);
        }

    }

}

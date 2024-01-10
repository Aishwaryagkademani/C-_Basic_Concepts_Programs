using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
namespace CsvAndJsoonFileHandling
{
    internal class CsvExamples
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public static void Main(string[] args)
        {
            string path = @"D:\visual studio C# projects\CsvAndJsoonFileHandling\CsvAndJsoonFileHandling\data.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            using(var streamRead=new StreamReader(path))
            using(var csv=new CsvReader(streamRead, config))
            {
                var result=csv.GetRecords<CsvExamples>();
                foreach(var record in result)
                {
                    Console.WriteLine(record.Name+" "+record.Age+" "+record.Country);
                }
            }
        }
    }
}

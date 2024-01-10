using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace CsvAndJsoonFileHandling
{
    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Country { get; set; }
    //}

    internal class Program
    {
        //    static void WriteToCsv(string filePath)
        //    {
        //        //try
        //        //{
        //            if (!File.Exists(filePath))
        //            {
        //                using (File.Create(filePath))
        //                {

        //                }
        //            }
        //            List<Person> people = new List<Person>
        //            {
        //                new Person{Name="jaya",Age=54,Country="India" },
        //                new Person{Name="Gebrial",Age=84,Country="Usa" },
        //                new Person{Name="Bob",Age=75,Country="Germany" }
        //            };
        //        var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
        //        {
        //            HasHeaderRecord = true
        //            };

        //            using (StreamWriter streamWriter = new StreamWriter(filePath))
        //            using (CsvWriter csvwriter = new CsvWriter(streamWriter, configPersons))
        //            {
        //                csvwriter.WriteRecords(people);
        //            }
        //        //}catch(Exception ex)
        //        //{
        //        //    throw ex;
        //        //}
        //    }

        public static void Main(string[] args)
        {
            // string directorypath = @"D:\visual studio C# projects\CsvAndJsoonFileHandling\CsvAndJsoonFileHandling";
            // string fileName = "data.csv";
            // string filepath = Path.Combine(directorypath, fileName);
            //WriteToCsv(filepath);

            WritingIntoCsvFile.writingtocsv();
           // WritingIntoCsvFile.ReadFromCsvFile();

        }
    }
}

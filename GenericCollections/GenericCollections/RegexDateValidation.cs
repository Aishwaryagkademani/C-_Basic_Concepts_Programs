using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace GenericCollections
{
    internal class RegexDateValidation
    {
        static void Main(string[] args)
        { 
            var candidates = new[]
            {

                "28-JUL-2023",
                "whatever",
                "89-ABC-1234",
                "11-JUN-2022",
                "11-JUN-2022, a date plus other stuff",
                "This is certainly not a date"
            };
        

            //string pattern = "[0-9]{2}-[A-Z]{3}-[0-9]{4}";
            //foreach(var a in candidates)
            //{
            //    if(Regex.IsMatch(a, pattern))
            //    {
            //        Console.WriteLine($"The string '{a}' matches the pattern '{pattern}'");
            //    }
            //}

            //Console.WriteLine();
            //string pattern2 = "^[0-9]{2}-[A-Z]{3}-[0-9]{4}$";
            //foreach (var a in candidates)
            //{
            //    if (Regex.IsMatch(a, pattern2))
            //    {
            //        Console.WriteLine($"The string '{a}' matches the pattern '{pattern2}'");
            //    }
            //}

            ManipulationOfData.RegexMaupulate();
            Console.WriteLine();
            ExtractionOfData.Extraction();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
namespace CsvAndJsoonFileHandling
{
    internal class WritingIntoCsvFile
    {
        public int rollno { get; set; }
        public string name { get; set; }


        public static void writingtocsv()
        {
            List<WritingIntoCsvFile> studlist = new List<WritingIntoCsvFile>();
            for (int i = 0; i < 10; i++)
            {
               // char c = (char)i;
                studlist.Add(new WritingIntoCsvFile { name = "class" + i, rollno = i });
            }
            string path = "D:\\visual studio C# projects\\CsvAndJsoonFileHandling\\CsvAndJsoonFileHandling";
            string filename = "writingToCsvFile.csv";
            var filepath = Path.Combine(path, filename);
           // var write = new StreamWriter(filepath);

            var csvConfigur=new CsvConfiguration(CultureInfo.InvariantCulture);
            using (var stream = new StreamWriter(filepath)) 
            using (var csvwrite = new CsvWriter(stream,csvConfigur))
            {
                csvwrite.WriteRecords(studlist);
            }
        }
            
    }
}


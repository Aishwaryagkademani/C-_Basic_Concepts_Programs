using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Review3
{
    internal class FileReadingAndWriting
    {
        public static void ReadAndWrite()
        {
            string path = @"D:\visual studio C# projects\Review3\ReadData.txt";
            
            var dataRead = File.ReadAllLines(path);
            
            //foreach(var line in dataRead)
            //{
            //    Console.WriteLine(line);
            //}

            Console.WriteLine("Data read from the file");
            Console.WriteLine();
            Console.WriteLine();
            string path2 = @"D:\visual studio C# projects\Review3\WriteData2.txt";
            File.WriteAllLines(path2, dataRead);
        }
    }
}

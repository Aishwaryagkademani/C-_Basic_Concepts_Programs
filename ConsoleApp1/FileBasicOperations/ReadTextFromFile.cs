using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    internal class ReadTextFromFile
    {
        public static void TextReadLines()
        {
            string path = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\Demo.txt";
            string[] lines;
            Console.WriteLine("using ReadAllLines Method.......");
            lines =File.ReadAllLines(path);
            Console.WriteLine("first line: {0}",lines[0]);
            Console.WriteLine("Second line: {0}", lines[1]);
            Console.WriteLine("Third line: {0}", lines[2]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("using ReadAllText Method.......");
            string allText = File.ReadAllText(path);
            Console.WriteLine(allText);


        }
    }
}

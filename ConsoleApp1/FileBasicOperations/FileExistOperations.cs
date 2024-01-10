using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    public class FileExistOperations
    {
        public static void TextFileExists()
        {
            string path = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\Demo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exist");
            }
            else 
            { 
                Console.WriteLine("file doesn't exist");
                File.Create(path);
            }
        }
    }
}

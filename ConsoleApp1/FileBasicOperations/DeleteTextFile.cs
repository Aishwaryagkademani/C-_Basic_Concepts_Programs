using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    internal class DeleteTextFile
    {
        public static void DeletingFiles()
        {
            string path = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\abc.txt";
            File.Delete(path);
            Console.WriteLine("file deleted");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    internal class CopyFileContentToAnotherFile
    {
        public static void CopyTextToAnotherFile()
        {
             string path = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\Demo.txt";

            string newpath = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\abc.txt";

            //string path = @"F:\demo.txt";
            //string newpath = @"F:\Aishwarya documents\democopy.txt";
            File.Copy(path, newpath);
                }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    public class FileExistOperationWithTextF
    {
        public void FindFileExist()
        {
            string path = @"D:\visual studio C# projects\ConsoleApp1\ConsoleApp1\Demo.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesnot exist");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileBasicOperations
{
    internal class FileStreamUsingToReadWrite
    {
        public static void FilestreamExample()
        {
            string path = @"D:\visual studio C# projects\ConsoleApp1\FileBasicOperations\DemofileStream.txt";
            //FileStream file = new FileStream(path, FileMode.Create);
            //Console.WriteLine("file created");

            // FileStream file = new FileStream(path, FileMode.CreateNew);
            //using( FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            // {
            //     file.WriteByte(66); ;//B
            //     Console.WriteLine("File written sucessfully");
            // }


            //using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write))
            //{
            //    file.WriteByte(65); ;//A
            //    Console.WriteLine("File written sucessfully");
            //}

            //using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            //{
            //    file.WriteByte(66); ;//B
            //    Console.WriteLine("File written sucessfully");
            //}

            //using (FileStream file = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite))
            //Console.WriteLine("File Emptyed to 0bytes sucessfully");

            File.WriteAllText(path, "Hello this is Aishwarya");
            Console.ReadLine();

        }
    }
}

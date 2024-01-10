using System;

namespace firstPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8 };
                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine(arrays[i]);
                }

                Console.WriteLine("The index value is " + arrays[2]);

                arrays[4] = 10;

                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine(arrays[i]);
                }

                Console.WriteLine("The length of array is :" + arrays.Length);

                foreach (int val in arrays)
                {
                    Console.WriteLine(val);
                }
            
        }
    }
    
}

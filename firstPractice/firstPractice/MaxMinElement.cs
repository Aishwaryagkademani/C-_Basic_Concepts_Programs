using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    internal class MaxMinElement
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[30];
            Console.WriteLine("Enter number of array elements");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max= arr[0];
            int min = arr[1];

            for(int i=0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i]< min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("minimum element of array " + min);
            Console.WriteLine("maximum element of array " + max);

        }
    }
}

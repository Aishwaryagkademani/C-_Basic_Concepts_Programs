using System;
using System.Collections.Generic;
using System.Text;

namespace firstPractice
{
    internal class SortArray
    {
        static void Main(string[] args)
        {
            int[] arr = {2,5,6,84,96,32,52,14};
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            for(int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
}    }


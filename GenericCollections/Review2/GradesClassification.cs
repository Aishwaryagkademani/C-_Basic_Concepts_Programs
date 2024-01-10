using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
    internal class GradesClassification
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score of student");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("student's grade is 'A'");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("student's grade is 'B'");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("student's grade is 'C'");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("student's grade is 'D'");
            }
            else
            {
                Console.WriteLine("student's grade is 'F'");
            }
        }
    }
}

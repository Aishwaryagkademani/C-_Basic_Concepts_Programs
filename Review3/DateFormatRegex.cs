using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Review3
{
    internal class DateFormatRegex
    {
        public static void ValidateDate()
        {
            string pattern = @"^\d{4}\-(0[1-9])|(1[0-2])\-([1-9]|[12]{1}[0-9]|3[0-1])$";
            string[] inputDate = { "2023-12-2", "2-12-2000", "0999-12-20", "1990-12-10", "2000-12-0", "2001-12-31" };
            // string inputDate2 = @"2-12-2000";
            foreach (string date in inputDate)
            {
                var valid = Regex.IsMatch(date, pattern);
                if (valid)
                {
                    Console.WriteLine(date+" is valid date");
                }
                else
                {
                    Console.WriteLine(date+" is invalid date");
                }
            }
        }
    }
}

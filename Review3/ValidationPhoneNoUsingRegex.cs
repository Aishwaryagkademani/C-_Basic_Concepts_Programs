using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Review3
{
    internal class ValidationPhoneNoUsingRegex
    {
        public static void validationPhoneNo()
        {
            string pattern;
            Console.WriteLine("choose country\n1.India\n2.Afghanistan\n3.Bahrain\n4.Brazil\n5.Cambodia\n6.Egypt");
            int country =int.Parse(Console.ReadLine());
            var valid=false;
            string input;
            switch(country)
            {
                case 1:
                    input = "+91 8956843521";
                    pattern = @"^\+91\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input,pattern);
                    break;
                case 2:
                    input = "+93 0568435218";
                    pattern = @"^\+93\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input, pattern);
                    break;
                case 3:
                    input = "+973 5484513521";
                    pattern = @"^\+973\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input, pattern);
                    break;
                case 4:
                    input = "+55 9568943521";
                    pattern = @"^\+55\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input,pattern);
                    break;
                case 5:
                    input = "+855 7568463521";
                    pattern = @"^\+855\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input, pattern);
                    break;
                case 6:
                    input = "+20 9568473521";
                    pattern = @"^\+20\s[1-9][0-9]{9}$";
                    valid = Regex.IsMatch(input,pattern);
                    break;
            }
            if (valid)
            {
                Console.WriteLine("number is valid");
            }
            else
                Console.WriteLine("number is not valid");
        }
    }
}

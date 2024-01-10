using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericCollections
{
    internal class RegularExpressionsExamples
    {
        public static void Main(string[] args)
        {
            string creditCardExpiryDate = @"^0[0-9]|1[1-2]\/20(2[3-9]|3[0-9])$";
            string input = "03/2024";

            if (Regex.IsMatch(input, creditCardExpiryDate))
            {
                Console.WriteLine("Credit card date is valid");
            }
            else
                Console.WriteLine("Credit card date is not valid");

            // string input2 = "12/2024";       ===> valid
            // string input3 = "22/2024";       ===> Invalid

            string digits15To16Patter = @"^\d{12,16}$";
            string digitsInput = "1234567891234556";//valid
                                                    // string digitsInpu2t = "15555555555234567891234556"; ==>invalid

            if (Regex.IsMatch(digitsInput, digits15To16Patter))
            {
                Console.WriteLine("number of digits is between 12 to 16 is valid");
            }
            else
                Console.WriteLine("number of digits is not between 12 to 16 is valid");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Credit card number.....");

            string creditCardNumberPattern = @"\d{4}\s\d{4}\s\d{4}\s\d{4}$";
            string inputCardNumber = "2323 2345 6567 2574";//valid
            // string inputCardNumber2 = "2323 23455 6567 2574";  ==> invalid

            if (Regex.IsMatch(inputCardNumber, creditCardNumberPattern))
            {
                Console.WriteLine("valid card number");
            }
            else
            {
                Console.WriteLine("invalid card number");
            }

            Console.WriteLine();
            Console.WriteLine("html tag validation........");
            string htmlTagPattern = @"<([a-z]+)>([^<]*)<\/[a-z]+>$";
            string[] inputHtmlTag = { "<a></a>", "<a>sfd</a>", "<html></a>", "<html</html>" };
            foreach (string a in inputHtmlTag)
            {
                if (Regex.IsMatch(a, htmlTagPattern))
                {
                    Console.WriteLine("{0} is valid html tag", a);
                }
                else
                    Console.WriteLine("{0} is invalid html tag", a);
            }
            Console.WriteLine();
            Console.WriteLine("html tag validation with attribute........");
            string htmlTagPatternwithAttribute = @"^<([a-z]+)([^>]*)>([^<]*)<\/[a-z]+>$";
            string tagInput = "<a href=\"dfdsfdsdfds\">dfdksfjdf</a>";
            // string[] inputHtmlTagWithAttribute = { "<a href= ></a>", "<a>sfd</a>", "<html></a>", "<html</html>" };
            //foreach (string a in inputHtmlTag)
            //{
            if (Regex.IsMatch(tagInput, htmlTagPatternwithAttribute))
            {
                Console.WriteLine("{0} is valid html tag", tagInput);
            }
            else
                Console.WriteLine("{0} is invalid html tag", tagInput);
            //}

            Console.WriteLine();
            Console.WriteLine("ipaddress validation..........");
            //string ipAddressPattern = @"2([0-4][0-9]|5[0-5])|1[0-9]{2}|[0-9]{1,2}\.2([0-4][0-9]|5[0-5])|1[0-9]{2}|[0-9]{1,2}\.2([0-4][0-9]|5[0-5])|1[0-9]{2}|[0-9]{1,2}\.2([0-4][0-9]|5[0-5])|1[0-9]{2}|[0-9]{1,2}$";
            //    //@"^2([0-4][0-9]|5[0-5])|1[0-9]{2}|[0-9]{1,2}\.2([0-4][0-9]|5[0-5])|1[0-9][0-9]|0[0-9][0-9])\.2([0-4][0-9]|5[0-5])|1[0-9][0-9]|0[0-9][0-9])\.2([0-4][0-9]|5[0-5])|1[0-9][0-9]|0[0-9][0-9])$";
            //string[] inputIpAddress = {"255.255.255.255","000.000.000.000","534.245.243.200","344.000.000.000","249.111.109.009","249.249.249.249"};
            //foreach (string a in inputIpAddress)
            //{
            //    if (Regex.IsMatch(a, ipAddressPattern))
            //    {
            //        Console.WriteLine("{0} is valid ip address", a);
            //    }
            //    else
            //        Console.WriteLine("{0} is invalid ip address", a);
            //}

            string ipAddressPattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            string[] inputIpAddress = { "255.255.255.255", "000.000.000.000", "534.245.243.200", "344.000.000.000", "249.111.109.009", "249.249.249.249","0.0.2.1", "1.0 "};

            foreach (string a in inputIpAddress)
            {
                if (Regex.IsMatch(a, ipAddressPattern))
                {
                    Console.WriteLine("{0} is valid IP address", a);
                }
                else
                {
                    Console.WriteLine("{0} is invalid IP address", a);
                }
            }

            Console.WriteLine();
            Console.WriteLine("url format validation.......");
            string urlPattern = @"^http(s)?:\/\/[a-z0-9\.\-]+\/([a-z0-9\.\-]*(\?.*)?)$";
            string inputUrl = "https://www.google.com/search?q=regular+expressions+example+using+escape+characters+in+c%23&sca_esv=591808843&tbm=isch&sxsrf=AM9HkKkUcGFpQqyQLi5tA-l9w7WCqkvpGg:1702891338599&source=lnms&sa=X&ved=2ahUKEwjQ2s_K1JiDAxXc3zgGHRwtDe4Q_AUoAnoECAQQBA";
            if (Regex.IsMatch(inputUrl, urlPattern))
            {
                Console.WriteLine("valid url");
            }
            else
            {
                Console.WriteLine("invalid url");
            }

            Console.WriteLine();
            Console.WriteLine("Extraction of month and year form credit card expiry date......");
            Console.WriteLine();
            string expiryDatePattern = @"^(0[0-9]|1[0-2])\/(20(2[3-9]|3[0-9]))$";
            var inputExpiryDate = "12/2023";
            var expiryMonth = Regex.IsMatch(inputExpiryDate, expiryDatePattern) ? Regex.Replace(inputExpiryDate, expiryDatePattern, "$1") : "";
            //Match expiryMonth = Regex.Match(inputExpiryDate, expiryDatePattern);
            //Console.WriteLine(expiryMonth.Groups[1].Value);
            //Console.WriteLine(expiryMonth.Groups[2].Value);
            Console.WriteLine(expiryMonth);
            var expiryYear = Regex.IsMatch(inputExpiryDate, expiryDatePattern) ? Regex.Replace(inputExpiryDate, expiryDatePattern, "$2") : "";
            Console.WriteLine(expiryYear);

            var inputExpiryDate2 = "05/2029";
            Match expiryMonth2 = Regex.Match(inputExpiryDate2, expiryDatePattern);
            Console.WriteLine(expiryMonth2.Groups[1].Value);
            Console.WriteLine(expiryMonth2.Groups[2].Value);

            Console.WriteLine();
            Console.WriteLine("remove white spaces");
            string spacePatter = @"\s(\s)+";
            string inputSpaceString = "hello      there";
            var my=Regex.Replace(inputSpaceString,spacePatter,"$1");
            Console.WriteLine(my);
        }
    }
}

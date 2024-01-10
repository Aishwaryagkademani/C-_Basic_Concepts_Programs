using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericCollections
{
    internal class ExtractionOfData
    {
        public static void Extraction()
        {
                    var contacts =
            "Emily Johnson+(555) 123-4567" +
            "\nBenjamin Williams+(555) 987-6543" +
            "\nOlivia Davis+(555) 222-3333" +
            "\nAlexander Smith+(555) 444-5555" +
            "\nSophia Brown+(555) 777-8888" +
            "\nWilliam Anderson+(555) 111-2222" +
            "\nAva Martinez+(555) 666-7777" +
            "\nJames Thompson+(555) 888-9999" +
            "\nIsabella Wilson+(555) 333-4444" +
            "\nMichael Taylor+(555) 777-1111";

            var pattern = @"\([0-9]{3}\)\s[0-9]{3}-[0-9]{4}";
            MatchCollection matches = Regex.Matches(contacts, pattern);

            Console.WriteLine("Here are the extracted phone numbers:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

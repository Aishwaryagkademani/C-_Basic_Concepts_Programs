using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace GenericCollections
{
    internal class ManipulationOfData
    {
        
        public static void RegexMaupulate()
        {
            var contacts = new[] {
            "Emily Johnson,(555) 123-4567",
            "Benjamin Williams,(555) 987-6543",
            "Olivia Davis,(555) 222-3333",
            "Alexander Smith,(555) 444-5555",
            "Sophia Brown,(555) 777-8888",
            "William Anderson,(555) 111-2222",
            "Ava Martinez,(555) 666-7777",
            "James Thompson,(555) 888-9999",
            "Isabella Wilson,(555) 333-4444",
            "Michael Taylor,(555) 777-1111"
             };

            var pattern = @"\([0-9]{3}\)\s[0-9]{3}-[0-9]{4}";

            foreach (var contact in contacts)
            {
                Console.WriteLine(Regex.Replace(contact, pattern, "(000) 000-0000"));
            }
        }


    }
}

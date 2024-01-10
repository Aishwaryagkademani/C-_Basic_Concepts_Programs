using System;
using System.Collections.Generic;
using System.Text;

namespace Review2
{
    internal class UnitTestForString
    {
       public int StringLengthTest()
        {
            string str=Console.ReadLine();
            int strLength=str.Length;
            if(strLength == 0 )
            {  
                Console.WriteLine("empty string");
                return 0;
            }
            else if(strLength == 1 )
            {
                Console.WriteLine("single character");
                return 1;
            }
            else 
            {
                Console.WriteLine("Longer string");
                return strLength;
            }
            
        }
    }
}

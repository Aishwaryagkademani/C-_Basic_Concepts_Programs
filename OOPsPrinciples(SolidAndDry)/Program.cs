using System;

namespace OOPsPrinciples_SolidAndDry_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle_SRPandOCP[] arr = {new Rectangle_SRPandOCP{height=23,width=32},
                new Rectangle_SRPandOCP{height=12,width=45},
                new Rectangle_SRPandOCP{height=19,width=14},
                new Rectangle_SRPandOCP{height=2.54,width=36.36},
                new Rectangle_SRPandOCP{height=63,width=42},
                new Rectangle_SRPandOCP{height=22,width=35} };
          double areaRectangle=  TotalArea_SRPandOCP.TotalArea(arr);
            Console.WriteLine("Total area of arrya of rectangles is : "+areaRectangle);

            Console.WriteLine();
          
            Square_SRPandOCP[] arrSquare = {new Square_SRPandOCP{radius = 13},
                new Square_SRPandOCP{radius=5},
                new Square_SRPandOCP{radius=12},
                new Square_SRPandOCP{radius=10},
                new Square_SRPandOCP{radius=8},
                new Square_SRPandOCP{radius=7} 
            };
          double areaSquare=  TotalArea_SRPandOCP.TotalArea(arrSquare);
            Console.WriteLine("Total area of array of squres is : "+areaSquare);


        }
    }
}

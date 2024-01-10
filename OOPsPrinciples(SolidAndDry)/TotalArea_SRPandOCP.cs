using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsPrinciples_SolidAndDry_
{
    internal class TotalArea_SRPandOCP
    {
        public static double TotalArea(Shapes_SRPandOCP[] arr)
        {
            double area=0;
            foreach(var item in arr)
            {
                area += item.Area();
            }
            return area;
        }
    }
}

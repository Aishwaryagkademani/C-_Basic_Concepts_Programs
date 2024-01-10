using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsPrinciples_SolidAndDry_
{
    public class Rectangle_SRPandOCP : Shapes_SRPandOCP
    {
        public double height { get; set; }
        public double width { get; set; }

        public override double Area()
        {
            return height*width;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsPrinciples_SolidAndDry_
{
    public class Square_SRPandOCP : Shapes_SRPandOCP
    {
        public double radius { get; set; }

       public override double Area()
        {
            return radius*radius*Math.PI;
        }
    }
}

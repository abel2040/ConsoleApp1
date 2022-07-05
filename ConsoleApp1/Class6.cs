using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Ishape
    {
        abstract public double calculatearea();
        abstract public double calculateparameter();
    }
    class circle : Ishape
    {
        public static readonly double pi = 3.14;
        public int radius { set; get; }

        public override double calculatearea()
        {
            double area = radius * radius * pi;
            return area;
        }

        public override double calculateparameter()
        {
            throw new NotImplementedException();
        }
    }
}

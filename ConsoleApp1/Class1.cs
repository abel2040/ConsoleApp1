using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class ishape
    {
        abstract public double calculatearea();
        abstract public double calculateparameter();
    }
    class circle : ishape
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
            double parameter = 2 * pi * radius;
            return parameter;
        }


    }

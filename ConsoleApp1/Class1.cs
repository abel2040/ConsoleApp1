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
    class rectangle : ishape
    {
        public int length { set; get; }
        public int weidth { set; get; }
        public override double calculatearea()
        {
            double area = length * weidth;
            return area;
        }

        public override double calculateparameter()
        {
            double Parameter = 2 * (length + weidth);
            return Parameter;
        }
    }
    class calculate
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            Console.WriteLine("enter the value of the radius");
            c.radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("circle area=" + c.calculatearea());
            Console.WriteLine("circle parameter=" + c.calculateparameter());
            rectangle r = new rectangle();
            Console.WriteLine("enter the values of length and width");
            r.length = Convert.ToInt32(Console.ReadLine());
            r.weidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rectangle area=" + r.calculatearea());
            Console.WriteLine("rectangle perimeter=" + r.calculateparameter());

        }
    }
}

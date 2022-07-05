using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class  Abstraction
    {
    }
    internal abstract class IShape
    {
     public   abstract void area();
      public  abstract void perimeter();
    }
    internal class Rectangle 
    { 
        public int width { set; get; }
        public int height { set; get; } 
    }


}

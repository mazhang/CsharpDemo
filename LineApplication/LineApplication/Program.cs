using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineApplication
{
    class Line
    {
        private double length;
        public Line()
        {
            Console.WriteLine("对象已创建！");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(10.0);
            Console.WriteLine("Line's length: {0}", line.getLength());
            Console.ReadLine();
        }
    }
}

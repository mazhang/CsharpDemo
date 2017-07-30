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
        public Line(double len)
        {
            Console.WriteLine("对象已创建！");
            length = len;
        }
        ~Line()
        {
            Console.WriteLine("对象已删除！");
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
            Line line = new Line(10.0);
            Console.WriteLine("Line's length: {0}", line.getLength());
            line.setLength(12.0);
            Console.WriteLine("Line's length: {0}", line.getLength());
            //Console.ReadLine();
        }
    }
}

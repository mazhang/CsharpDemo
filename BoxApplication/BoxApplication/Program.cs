using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxApplication
{
    class Box
    {
        public double Length;
        public double Breadth;
        public double Height;

        public void setLength(double len)
        {
            Length = len;
        }
        public void setBreadth(double bre)
        {
            Breadth = bre;
        }
        public void setHeight(double hei)
        {
            Height = hei;
        }
        public double getVolume()
        {
            return Length * Breadth * Height;
        }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            box1.setLength(5.0);
            box1.setBreadth(6.0);
            box1.setHeight(7.0);

            box2.setLength(10.0);
            box2.setBreadth(11.0);
            box2.setHeight(12.0);

            Console.WriteLine("box1's volume: {0}", box1.getVolume());
            Console.WriteLine("box2's volume: {0}", box2.getVolume());
            Console.ReadKey();
        }
    }
}
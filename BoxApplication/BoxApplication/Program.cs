using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxApplication
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            double volume = 0.0;

            box1.length = 5.0;
            box1.breadth = 6.0;
            box1.height = 7.0;

            box2.length = 10.0;
            box2.breadth = 11.0;
            box2.height = 12.0;

            volume = box1.length * box1.breadth * box1.height;
            Console.WriteLine("box1's volume: {0}", volume);

            volume = box2.length * box2.breadth * box2.height;
            Console.WriteLine("box2's volume: {0}", volume);

            Console.ReadKey();
        }
    }
}
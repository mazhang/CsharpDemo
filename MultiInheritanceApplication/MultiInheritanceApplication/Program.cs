using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
    }

    public interface PaintCost
    {
        int GetCost(int area);
    }

    class Rectangle : Shape, PaintCost
    {
        public int GetArea()
        {
            return width * height;
        }
        public int GetCost(int area)
        {
            return area * 70;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            //int area;
            rect.SetHeight(10);
            rect.SetWidth(11);
            Console.WriteLine("总面积：{0}", rect.GetArea());
            Console.WriteLine("油漆总成本： {0}", rect.GetCost(rect.GetArea()));
            Console.ReadLine();
        }
    }
}

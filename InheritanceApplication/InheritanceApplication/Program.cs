using System;

namespace InheritanceApplication
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

    class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetWidth(10);
            rect.SetHeight(11);

            Console.WriteLine("The area of rect is: {0}", rect.GetArea());
            Console.ReadLine();
        }
    }
}

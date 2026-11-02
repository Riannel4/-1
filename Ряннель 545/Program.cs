using System;

namespace RectangleApp
{
    public class Rectangle
    {
        public double Height;
        public double Width;

        public void ShowInfo()
        {
            Console.WriteLine($"Прямоугольник: высота = {Height}, ширина = {Width}");
        }

        public double Perimetr()
        {
            return 2 * Height + 2 * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRect = new Rectangle();

            myRect.Height = 2;
            myRect.Width = 3;

            myRect.ShowInfo();

            double p = myRect.Perimetr();
            Console.WriteLine($"Периметр прямоугольника: {p}");

            Console.ReadLine();
        }
    }
}
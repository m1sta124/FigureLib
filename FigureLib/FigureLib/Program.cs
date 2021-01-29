using System;
using FigureArea;

namespace FigureLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //var circle = new Figure();
            //circle.radius = double.Parse(Console.ReadLine());
            //circle.area = Figure.Circle_area(circle.radius);
            //Console.WriteLine(circle.area);

            var triangle = new Figure();
            Console.WriteLine("введите длину первой стороны");
            triangle.first_side = double.Parse(Console.ReadLine());
            Console.WriteLine("введите длину второй стороны");
            triangle.second_side = double.Parse(Console.ReadLine());
            Console.WriteLine("введите длину третьей стороны");
            triangle.third_side = double.Parse(Console.ReadLine());

            triangle.area = Figure.Triangle_area(triangle.first_side, triangle.second_side, triangle.third_side);
            Console.WriteLine("S треугольника = " + triangle.area);
        }
    }
}

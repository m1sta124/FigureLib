﻿using System;

namespace FigureArea
{
    public class Figure
    {
        public double radius; // радиус 
        public double area; // площадь фигуры
        public double first_side; // первая сторона
        public double second_side; // вторая сторона
        public double third_side; // третья сторона

        //т.к не существует общей формулы площади для всех фигур, то реализовать код, в котором неизвестен тип фигуры, невозможно.

        public static double Circle_area(double rad) //площадь круга
        {
            double area = 0;
            area = Math.PI * Math.Pow(rad, 2);
            return area;
        }

        public static double Triangle_area(double first_side, double second_side, double third_side) //площадь треугольника по трём сторонам
        {
            double area = 0;
            double halfPerimetr = (first_side + second_side + third_side) / 2;
            double max_side = first_side;
            // проверка вида треугольника
            if (max_side < second_side)
            {
                max_side = second_side;
                if (Math.Pow(max_side, 2) == Math.Pow(first_side, 2) + Math.Pow(third_side, 2))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }

            }
            if (max_side < third_side)
            {
                max_side = third_side;
                if (Math.Pow(max_side, 2) == Math.Pow(first_side, 2) + Math.Pow(second_side, 2))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
            }
            if (Math.Pow(max_side, 2) == Math.Pow(second_side, 2) + Math.Pow(third_side, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            // конец проверки
            area = Math.Sqrt(halfPerimetr * (halfPerimetr - first_side) * (halfPerimetr - second_side) * (halfPerimetr - third_side));
            return area;
        }

    }
}

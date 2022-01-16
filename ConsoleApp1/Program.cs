using System;
using AreaCalculator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер фигуры для создания\n" +
                              "1. Круг\n" +
                              "2. Треугольник");
            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("Введите радиус круга\n");
                    var radius = Convert.ToDouble(Console.ReadLine());
                    var circleCreator = new CreateCircle(radius);
                    circleCreator.CreateFigure();
                    break;
                case "2":
                    Console.WriteLine("Введите сторону A: ");
                    var a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону B: ");
                    var b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону C: ");
                    var c = Convert.ToDouble(Console.ReadLine());
                    var triangleCreator = new CreateTriangle(a, b, c);
                    triangleCreator.CreateFigure();
                    break;
            }
            Console.WriteLine("Завершение работы");
        }
    }
}
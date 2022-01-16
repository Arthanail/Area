using System;

namespace AreaCalculator
{
    public abstract class Figure
    {
    }

    internal class Circle : Figure
    {
        public Circle(double areaCircle)
        {
            Console.WriteLine($"Площадь круга: {areaCircle}");
        }
    }

    internal class Triangle : Figure
    {
        public Triangle(double areaTriangle)
        {
            Console.WriteLine($"Площадь Треугольника: {areaTriangle}");
        }
    }

    public abstract class Creator
    {
        public abstract Figure CreateFigure();
    }

    public class CreateCircle : Creator
    {
        private double Radius { get;}
        public CreateCircle(double radius)
        {
            Radius = radius;
        }
        public override Figure CreateFigure()
        {
            var areaCircle = Math.PI * Math.Pow(Radius, 2);
            return new Circle(areaCircle);
        }
    }

    public class CreateTriangle : Creator
    {
        private double A { get;}
        private double B { get;}
        private double C { get;}
        public CreateTriangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private bool RectangularTest()
        {
            if (A > B && A > C)
            {
                var hypotenuse = Math.Pow(A, 2);
                var leg = Math.Pow(B, 2) + Math.Pow(C, 2);
                if (hypotenuse == leg)
                {
                    return true;
                }
            }

            else if (B > A && B > C)
            {
                var hypotenuse = Math.Pow(B, 2);
                var leg = Math.Pow(A, 2) + Math.Pow(C, 2);
                if (hypotenuse == leg)
                {
                    return true;
                }
            }

            else if (C > A && C > B)
            {
                var hypotenuse = Math.Pow(C, 2);
                var leg = Math.Pow(A, 2) + Math.Pow(B, 2);
                if (hypotenuse == leg)
                {
                    return true;
                }
            }

            return false;
        }
        public override Figure CreateFigure()
        {
            if (RectangularTest() == true)
            {
                if (A > B && A > C)
                {
                    var a = (B * C) / 2;
                    return new Triangle(a);
                }
                if (B > A && B > C)
                {
                    var b = (A * C) / 2;
                    return new Triangle(b);
                }
                if (C > A && C > B)
                {
                    var c = (A * B) / 2;
                    return new Triangle(c);
                }
            }
            var p = (A + B + C) / 2;
            var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return new Triangle(s);
        }
    }
}
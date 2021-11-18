using System;

namespace AreaOfShapes
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private readonly double r;

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(r));
            }

            this.r = r;
        }

        public override double GetArea() => Math.PI * r * r;
    }

    public class Triangle : Shape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            this.a = a;
            this.b = b;
            this.c = c;
        }

        private static void ValidateSides(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentOutOfRangeException("The sum of the lengths of any two sides must be greater than length of the remaining side");
            }
        }

        public override double GetArea()
        {
            var s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public bool IsRightAngled() => a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b;
    }
}

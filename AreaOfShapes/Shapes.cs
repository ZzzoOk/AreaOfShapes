/* возможно не совсем то что ожидалось,
 * т.к. не понял два следующих пункта:
 * - Легкость добавления других фигур
 * - Вычисление площади фигуры без знания типа фигуры в compile-time
 */

using System;
using System.IO;

namespace AreaOfShapes
{
    // вычисление фигуры без знания типа фигуры, т.е. полиморфизм
    // только не понимаю как вычислить площадь во время компиляции
    // знаю, что во время компиляции вычисляются выражения в const
    public static class Shapes
    {
        public static double GetArea(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(r));
            }

            return Math.PI * r * r;
        }

        public static double GetArea(double a, double b, double c)
        {
            Triangle.ValidateSides(a, b, c);

            var s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    public static class Circle
    {
        public static double GetArea(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(r));
            }

            return Math.PI * r * r;
        }
    }

    public static class Triangle
    {
        public static void ValidateSides(double a, double b, double c)
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

        public static double GetArea(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            var s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool IsRightAngled(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            return a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b;
        }
    }
}

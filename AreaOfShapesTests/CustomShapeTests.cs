using AreaOfShapes;
using System;
using Xunit;

namespace AreaOfShapesTests
{
    public class CustomShapeTests
    {
        class Rectangle : Shape
        {
            private readonly double a;
            private readonly double b;

            public Rectangle(double a, double b)
            {
                if (a <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(a));
                }

                if (b <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(b));
                }

                this.a = a;
                this.b = b;
            }

            public override double GetArea() => a * b;
        }

        [Fact]
        public void GetArea_WithValidSides_ReturnsValue()
        {
            var rectangle = new Rectangle(3, 4);

            var expected = 12;

            var actual = rectangle.GetArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void GetArea_WhenOneSideIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(-3, 4));
        }
    }
}
using AreaOfShapes;
using System;
using Xunit;

namespace AreaOfShapesTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_WithValidSides_ReturnsValue()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = 6;

            var actual = Triangle.GetArea(a, b, c);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void GetArea_WhenOneSideIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            var a = 3;
            var b = 4;
            var c = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.GetArea(a, b, c));
        }

        [Fact]
        public void GetArea_WhenOneSideIsGreaterThanOthers_ShouldThrowArgumentOutOfRange()
        {
            var a = 3;
            var b = 4;
            var c = 8;

            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.GetArea(a, b, c));
        }

        [Fact]
        public void ShapesGetArea_WithValidSides_ReturnsValue()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = 6;

            var actual = Shapes.GetArea(a, b, c);

            Assert.Equal(expected, actual, 2);
        }
    }
}
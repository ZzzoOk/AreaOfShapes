using AreaOfShapes;
using System;
using Xunit;

namespace AreaOfShapesTests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_WithValidRadius_ReturnsValue()
        {
            var r = 3;
            var expected = 28.27;

            var actual = Circle.GetArea(r);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void GetArea_WhenRadiusIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            var r = -4;

            Assert.Throws<ArgumentOutOfRangeException>(() => Circle.GetArea(r));
        }

        [Fact]
        public void ShapesGetArea_WithValidRadius_ReturnsValue()
        {
            var r = 3;
            var expected = 28.27;

            var actual = Shapes.GetArea(r);

            Assert.Equal(expected, actual, 2);
        }
    }
}
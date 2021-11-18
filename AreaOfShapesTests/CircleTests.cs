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
            var circle = new Circle(3);

            var expected = 28.27;

            var actual = circle.GetArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void GetArea_WhenRadiusIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-4));
        }
    }
}
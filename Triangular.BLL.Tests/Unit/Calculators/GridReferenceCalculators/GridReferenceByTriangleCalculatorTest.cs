using System;
using Xunit;
using Triangular.BLL;
using Triangular.BLL.Calculators.GridReferenceCalculators;
using Moq;

namespace Triangular.BLL.Tests.Unit.Calculators.GridReferenceCalculators
{
    public class TriangleByGridReferenceCalculatorTest
    {
        [Fact]
        public void ReturnsGridReferenceForTriangleE8Coordinates()
        {
            Grid grid = new Grid(60, 60, 10);

            Triangle triangle = new Triangle();
            triangle.AddAngleCoordinate(new Coordinate(40, 40));
            triangle.AddTopLeftCoordinate(new Coordinate(30, 40));
            triangle.AddBottomRightCoordinate(new Coordinate(40, 50));

            GridReferenceByTriangleCalculator calculator = new GridReferenceByTriangleCalculator();
            GridReference gridReference = calculator.Calculate(grid, triangle);

            Assert.Equal(8, gridReference.Column);
            Assert.Equal('E', gridReference.Row);
        }

        [Fact]
        public void ReturnsGridReferenceForTriangleF11Coordinates()
        {
            Grid grid = new Grid(60, 60, 10);

            Triangle triangle = new Triangle();
            triangle.AddAngleCoordinate(new Coordinate(50, 60));
            triangle.AddTopLeftCoordinate(new Coordinate(50, 50));
            triangle.AddBottomRightCoordinate(new Coordinate(60, 60));

            GridReferenceByTriangleCalculator calculator = new GridReferenceByTriangleCalculator();
            GridReference gridReference = calculator.Calculate(grid, triangle);

            Assert.Equal(11, gridReference.Column);
            Assert.Equal('F', gridReference.Row);
        }
    }
}

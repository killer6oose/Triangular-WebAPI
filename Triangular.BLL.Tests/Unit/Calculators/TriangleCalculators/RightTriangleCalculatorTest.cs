using System;
using Xunit;
using Triangular.BLL;
using Triangular.BLL.Calculators.TriangleCalculators;
using Moq;

namespace Triangular.BLL.Tests.Unit.Calculators.TriangleCalculators
{
    public class RightTriangleCalculatorTest
    {
        [Fact]
        public void FindsLeftTriangleAtA2()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 2);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 1);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            RightTriangleCalculator rightTriangleFinder = new RightTriangleCalculator();
            IGridShape triangle = rightTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 0 && c.Y == 0);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 10 && c.Y == 0);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 10 && c.Y == 10);
        }

        [Fact]
        public void FindsLeftTriangleAtD10()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 10);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 4);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            RightTriangleCalculator rightTriangleFinder = new RightTriangleCalculator();
            IGridShape triangle = rightTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 40 && c.Y == 30);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 50 && c.Y == 30);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 50 && c.Y == 40);
        }

        [Fact]
        public void FindsLeftTriangleAtF12()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 12);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 6);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            RightTriangleCalculator rightTriangleFinder = new RightTriangleCalculator();
            IGridShape triangle = rightTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 50 && c.Y == 50);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 60 && c.Y == 50);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 60 && c.Y == 60);
        }
    }
}

using System;
using Xunit;
using Triangular.BLL;
using Triangular.BLL.Calculators.TriangleCalculators;
using Moq;

namespace Triangular.BLL.Tests.Unit.Calculators.TriangleCalculators
{
    public class LeftTriangleCalculatorTest
    {
        [Fact]
        public void FindsLeftTriangleAtA1()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 1);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 1);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            LeftTriangleCalculator leftTriangleFinder = new LeftTriangleCalculator();
            IGridShape triangle = leftTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 0 && c.Y == 0);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 0 && c.Y == 10);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 10 && c.Y == 10);
        }

        [Fact]
        public void FindsLeftTriangleAtC5()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 5);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 3);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            LeftTriangleCalculator leftTriangleFinder = new LeftTriangleCalculator();
            IGridShape triangle = leftTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 20 && c.Y == 20);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 20 && c.Y == 30);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 30 && c.Y == 30);
        }

        [Fact]
        public void FindsLeftTriangleAtF11()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 11);
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 6);

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            LeftTriangleCalculator leftTriangleFinder = new LeftTriangleCalculator();
            IGridShape triangle = leftTriangleFinder.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 50 && c.Y == 50);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 50 && c.Y == 60);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 60 && c.Y == 60);
        }

    }
}

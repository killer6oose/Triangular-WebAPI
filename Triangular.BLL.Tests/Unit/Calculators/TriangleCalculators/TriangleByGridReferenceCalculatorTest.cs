using System;
using Xunit;
using Triangular.BLL;
using Triangular.BLL.Calculators.TriangleCalculators;
using Moq;

namespace Triangular.BLL.Tests.Unit.Calculators.TriangleCalculators
{
    public class TriangleByGridReferenceCalculatorTest
    {
        [Fact]
        public void ReturnsTriangleAtGivenGridReference()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 2);
            moqGridReference.Setup(x => x.Row)
                            .Returns(() => 'C');
            moqGridReference.Setup(x => x.GetNumericRow())
                .Returns(() => 3);

            var moqFactory = new Mock<ITriangleCalculatorFactory>();
            moqFactory.Setup(x => x.Make(moqGridReference.Object))
                .Returns(new RightTriangleCalculator());

            var moqGrid = new Mock<IGrid>();
            moqGrid.Setup(x => x.CellSize)
                .Returns(() => 10);

            TriangleByGridReferenceCalculator calculator = new TriangleByGridReferenceCalculator(moqFactory.Object);
            IGridShape triangle = calculator.Calculate(moqGrid.Object, moqGridReference.Object);

            Assert.Equal(3, triangle.Coordinates.Count);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 0 && c.Y == 20);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 10 && c.Y == 20);
            Assert.Contains(triangle.Coordinates, (c) => c.X == 10 && c.Y == 30);
        }
    }
}

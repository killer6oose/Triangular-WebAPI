using Moq;
using Triangular.BLL.Calculators;
using Triangular.BLL.Factories;
using Triangular.BLL.Models;
using Xunit;

namespace Triangular.BLL.Tests.Unit.Calculators.TriangleCalculators
{
    public class TriangleCalculatorFactoryTest
    {
        [Fact]
        public void ReturnsLeftTriangleFinderWithOddColumnGridReference()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 9);

            TriangleCalculatorFactory triangleFinderFactory = new TriangleCalculatorFactory();
            ITriangleCalculator triangleFinder = triangleFinderFactory.Make(moqGridReference.Object);

            Assert.IsType(new LeftTriangleCalculator().GetType(), triangleFinder);
        }

        [Fact]
        public void ReturnsRightTriangleFinderWithEvenColumnGridReference()
        {
            var moqGridReference = new Mock<IGridReference>();
            moqGridReference.Setup(x => x.Column)
                .Returns(() => 10);

            TriangleCalculatorFactory triangleFinderFactory = new TriangleCalculatorFactory();
            ITriangleCalculator triangleFinder = triangleFinderFactory.Make(moqGridReference.Object);

            Assert.IsType(new RightTriangleCalculator().GetType(), triangleFinder);
        }
    }
}
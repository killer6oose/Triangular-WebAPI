using System;
using Xunit;
using Triangular.BLL;
using Moq;

namespace Triangular.BLL.Tests.Unit
{
    public class TriangularGridTest
    {
        [Fact]
        public void ReturnsCorrectWidthAndHeight()
        {
            TriangularGrid triangularGrid = new TriangularGrid(60, 60, 10);

            Assert.Equal(60, triangularGrid.Height);
            Assert.Equal(60, triangularGrid.Width);
            Assert.Equal(10, triangularGrid.CellSize);
        }

        [Fact]
        public void ReturnsCorrectColumnCount()
        {
            TriangularGrid triangularGrid = new TriangularGrid(60, 60, 10);

            Assert.Equal(12, triangularGrid.GetColumnCount());
        }
    }
}

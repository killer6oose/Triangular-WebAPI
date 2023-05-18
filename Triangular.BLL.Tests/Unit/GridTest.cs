using System;
using Xunit;
using Triangular.BLL;

namespace Triangular.BLL.Tests.Unit
{
    public class GridTest
    {
        [Fact]
        public void ReturnsCorrectWidthAndHeight()
        {
            Grid grid = new Grid(60, 60, 10);

            Assert.Equal(60, grid.Height);
            Assert.Equal(60, grid.Width);
            Assert.Equal(10, grid.CellSize);
        }

        [Fact]
        public void ReturnsCorrectRowCount()
        {
            Grid grid = new Grid(100, 100, 20);

            Assert.Equal(5, grid.GetRowCount());
        }

        [Fact]
        public void ReturnsCorrectColumnCount()
        {
            Grid grid = new Grid(100, 100, 20);

            Assert.Equal(5, grid.GetColumnCount());
        }
    }
}

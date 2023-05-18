using System;
using Xunit;
using Triangular.BLL;

namespace Triangular.BLL.Tests.Unit
{
    public class GridReferenceTest
    {
        [Fact]
        public void ReturnsRowAndColumn()
        {
            GridReference gridReference = new GridReference('A', 10);

            Assert.Equal('A', gridReference.Row);
            Assert.Equal(10, gridReference.Column);
        }

        [Fact]
        public void ConvertsRowToUpperCase()
        {
            GridReference gridReference = new GridReference('a', 10);

            Assert.Equal('A', gridReference.Row);
        }

        [Fact]
        public void ReturnsNumericRowForA()
        {
            GridReference gridReference = new GridReference('A', 10);

            Assert.Equal(1, gridReference.GetNumericRow());
        }

        [Fact]
        public void ReturnsNumericRowForZ()
        {
            GridReference gridReference = new GridReference('Z', 10);

            Assert.Equal(26, gridReference.GetNumericRow());
        }

        [Fact]
        public void ReturnsNumericRowForLowerCase()
        {
            GridReference gridReference = new GridReference('d', 10);

            Assert.Equal(4, gridReference.GetNumericRow());
        }
    }
}

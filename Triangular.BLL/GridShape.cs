using System;
using System.Collections.Generic;
using System.Text;

namespace Triangular.BLL
{
    public class GridShape : IGridShape
    {
        public List<Coordinate> Coordinates = new List<Coordinate>();

        IList<Coordinate> IGridShape.Coordinates { get => Coordinates; }

        public IGridShape AddCoordinate(Coordinate coordinate)
        {
            this.Coordinates.Add(coordinate);

            return this;
        }
    }
}

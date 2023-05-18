using System.Collections.Generic;

namespace Triangular.BLL.Models
{
    public class GridShape : IGridShape
    {
        public List<Coordinate> Coordinates = new List<Coordinate>();

        IList<Coordinate> IGridShape.Coordinates { get => Coordinates; }

        public IGridShape AddCoordinate(Coordinate coordinate)
        {
            Coordinates.Add(coordinate);

            return this;
        }
    }
}
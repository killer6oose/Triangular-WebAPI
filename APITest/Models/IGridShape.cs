using System.Collections.Generic;

namespace Triangular.BLL
{
    public interface IGridShape
    {
        IList<Coordinate> Coordinates { get; }

        IGridShape AddCoordinate(Coordinate coordinate);
    }
}
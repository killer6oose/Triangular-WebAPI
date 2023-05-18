using System;
using System.Collections.Generic;
using System.Text;

namespace Triangular.BLL
{
    public interface IGridShape
    {
        IList<Coordinate> Coordinates { get; }

        IGridShape AddCoordinate(Coordinate coordinate);
    }
}

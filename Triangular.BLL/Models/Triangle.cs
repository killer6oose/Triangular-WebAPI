namespace Triangular.BLL.Models
{
    public class Triangle : GridShape
    {
        public Coordinate AngleCoordinate { get; set; }
        public Coordinate TopLeftCoordinate { get; set; }
        public Coordinate BottomRightCoordinate { get; set; }

        public Triangle AddAngleCoordinate(Coordinate angleCoordinate)
        {
            AngleCoordinate = angleCoordinate;
            Coordinates.Add(angleCoordinate);

            return this;
        }

        public Triangle AddTopLeftCoordinate(Coordinate topLeftCoordinate)
        {
            TopLeftCoordinate = topLeftCoordinate;
            Coordinates.Add(topLeftCoordinate);

            return this;
        }

        public Triangle AddBottomRightCoordinate(Coordinate bottomRightCoordinate)
        {
            BottomRightCoordinate = bottomRightCoordinate;
            Coordinates.Add(bottomRightCoordinate);

            return this;
        }
    }
}
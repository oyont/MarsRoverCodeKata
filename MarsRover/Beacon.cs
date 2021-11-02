using MarsRover.Directions;

namespace MarsRover
{
    public class Beacon
    {
        public Position Position { get; }
        public IDirection Direction { get; }

        public Beacon(Position position, IDirection direction)
        {
            Position = position;
            Direction = direction;
        } 
    }
}
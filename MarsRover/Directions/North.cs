namespace MarsRover.Directions
{
    public class North : IDirection
    {
        public Position Move(Position position)
        {
            return new(position.X, position.Y + 1);
        }

        public string CompassPoint => "N";
        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }
    }
}
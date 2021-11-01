namespace MarsRover.Directions
{
    public class West : IDirection
    {
        public Position Move(Position position)
        {
            return new(position.X -1  , position.Y );
        }

        public string CompassPoint => "W";
        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }
    }
}
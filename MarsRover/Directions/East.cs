namespace MarsRover.Directions
{
    public class East : IDirection
    {
        public Position Move(Position position)
        {
            return new(position.X + 1, position.Y );
        }

        public string CompassPoint => "E";
        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return  new South();
        }
    }
}
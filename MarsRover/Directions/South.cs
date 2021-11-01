namespace MarsRover.Directions
{
    public class South : IDirection
    {
        public Position Move(Position position)
        {
            return new Position(position.X , position.Y -1 );
        }

        public string CompassPoint => "S";
        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return  new West();
        }
    }
}
namespace MarsRover.Directions
{
    public interface IDirection
    {
        Position Move(Position position);
        string CompassPoint { get;  }
        IDirection TurnLeft();
        IDirection TurnRight();
    }
}
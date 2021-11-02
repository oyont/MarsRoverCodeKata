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
        
        public override bool Equals( object ob ){
            if( ob is IDirection ) {
                IDirection c = (IDirection) ob;
                return CompassPoint==c.CompassPoint;
            }
            else {
                return false;
            }
        }

        public override int GetHashCode(){
            return CompassPoint.GetHashCode();
        }
    }
}
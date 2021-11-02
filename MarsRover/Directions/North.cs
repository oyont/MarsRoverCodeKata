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
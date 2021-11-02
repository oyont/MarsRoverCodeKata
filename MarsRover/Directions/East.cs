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
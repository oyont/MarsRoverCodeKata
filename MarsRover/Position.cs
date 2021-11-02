namespace MarsRover
{
    public  class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
 
        public override bool Equals( object ob ){
            if( ob is Position ) {
                Position c = (Position) ob;
                return X==c.X && Y==c.Y;
            }
            else {
                return false;
            }
        }

        public override int GetHashCode(){
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
using System;
using System.Collections;

namespace MarsRover
{
    public  class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
        
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
            return HashCode.Combine(X.GetHashCode() , Y.GetHashCode());
        }
        
        public static bool operator == (Position lhs, Position rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                return false;
            }
            return lhs.Equals(rhs);
        }
        
        public static bool operator !=(Position lhs, Position rhs) => !(lhs == rhs);
    }
}
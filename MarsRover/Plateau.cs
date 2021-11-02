using System.Collections.Generic;
using System.Linq;
using MarsRover.Directions;

namespace MarsRover
{
    public class Plateau
    {
        public Plateau(int upperX, int upperY)
        {
            UpperX = upperX;
            UpperY = upperY;
        }

        public int UpperX { get; }
        public int UpperY { get; }
        public List<Beacon> Beacons { get; } = new();
        
        public bool HasBeaconAtPosition(Position lastPosition, IDirection direction)
        {
            return !Beacons.Any(
                beacon=> beacon.Position == lastPosition && Equals(beacon.Direction, direction));
        }
    }
}
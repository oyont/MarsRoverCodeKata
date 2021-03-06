using System;
using System.Linq;
using MarsRover.Directions;

namespace MarsRover
{
    public class Rover
    {
        private Position Position { get; set; }
        private IDirection Direction { get; set; }
 
        public Rover(string state)
        {
            var coordinates = state.Split(' ');
            Position = new Position(int.Parse(coordinates[0]), int.Parse(coordinates[1]));

            Direction = DirectionFactory.CreateDirection(coordinates[2]);
        }

        public string Control(string commands, Plateau plateau)
        {
            foreach (var command in commands)
            {
                if (command == 'M')
                {
                    var lastPosition = Position;
                    if (plateau.HasBeaconAtPosition(lastPosition,Direction))
                    {
                        Move();
                    }
                    
                    if (Position.X > plateau.UpperX || Position.Y > plateau.UpperY)
                    {
                        plateau.Beacons.Add(new Beacon(lastPosition,Direction));
                        return $"{lastPosition.X} {lastPosition.Y} {Direction.CompassPoint} RIP";
                    }
                }
                else if (command == 'R')
                {
                    TurnRight();
                }
                else if (command == 'L')
                {
                    TurnLeft();
                }
            }

            return $"{Position.X} {Position.Y} {Direction.CompassPoint}";
        }



        private void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        private void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        private void Move()
        {
            Position = Direction.Move(Position);
        }
    }
}
using FluentAssertions;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverShould
    {
       [Test]
        public void Initialize()
        {
            // arrange
            var rover = new Rover(0,0,'N');

            rover.ToString().Should().Be("0 0 N");
        }
    }

    public class Rover
    {
        public int X { get; }
        public int Y { get; }
        public char Direction { get; }

        public Rover(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
    }
}
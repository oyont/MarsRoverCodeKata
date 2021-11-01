using FluentAssertions;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverShould
    {
       [Test]
        public void Initialize()
        {
            var rover = new Rover("0 0 N");

            rover.ToString().Should().Be("0 0 N");
        }

        [TestCase("0 0 N","M", "0 1 N")]
        [TestCase("0 0 E","M", "1 0 E")]
        [TestCase("0 0 E","R", "0 0 S")]
        [TestCase("0 0 E","L", "0 0 N")]
        [TestCase("1 2 N","LMLMLMLMM", "1 3 N")]
        [TestCase("3 3 E","MMRMMRMRRM", "5 1 E")]
        public void Be_Controlled_By_Commands(string initialState,string commands, string expected)
        {
            var rover = new Rover(initialState);

            rover.Control(commands);

            rover.ToString().Should().Be(expected);
        }
    }
}
using FluentAssertions;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        private Plateau _plateau;
        
        [SetUp]
        public void Setup()
        {
            _plateau = new Plateau(5, 5);
        }
       [Test]
        public void Initialize()
        {
            var rover = new Rover("0 0 N");
            var result = rover.Control("", _plateau);

            result.Should().Be("0 0 N"); 
        }

        [TestCase("0 0 N","M", "0 1 N")]
        [TestCase("0 0 E","M", "1 0 E")]
        [TestCase("0 0 E","R", "0 0 S")]
        [TestCase("0 0 E","L", "0 0 N")]
        [TestCase("1 2 N","LMLMLMLMM", "1 3 N")]
        [TestCase("3 3 E","MMRMMRMRRM", "5 1 E")]
        public void Rover_Should_Be_Controlled_By_Commands(string initialState,string commands, string expected)
        {
            var rover = new Rover(initialState);

            var result = rover.Control(commands, _plateau);

            result.Should().Be(expected);
        }
 
[Test]
        public void Rover_Control_Should_Print_RIP_If_Rover_Falls_Off_The_Edge()
        {
            var rover1 = new Rover("1 2 N");
            var rover2 = new Rover("3 3 E");
            var rover3 = new Rover("4 1 S");

            var commands1 = "LMLMLMLMM";
            var commands2 = "MMRMMLMRRM";
            var commands3 = "MLMLMRMRM";
              
            var result1 = rover1.Control(commands1, _plateau);
            var result2 = rover2.Control(commands2, _plateau);
            var result3 = rover3.Control(commands3, _plateau);

            result1.Should().Be("1 3 N");
            result2.Should().Be("5 1 E RIP");
            result3.Should().Be("5 0 S");
        }
    }
}
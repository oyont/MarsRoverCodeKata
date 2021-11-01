using System;

namespace MarsRover.Directions
{
    public static class DirectionFactory
    {
        public static IDirection CreateDirection(string direction)
        {
            return direction switch
            {
                "N" => new North(),
                "E" => new East(),
                "W" => new West(),
                "S" => new South(),
                _ => throw new NotSupportedException($"{direction} is not supported as Direction.")
            };
        }
    }
}
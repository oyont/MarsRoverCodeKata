using System;

namespace MarsRover
{
    public class Rover
    {
        private int X { get; set; }
        private int Y { get; set; }
        private string Direction { get; set; }

        public Rover(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public Rover(string state)
        {
            var coordinates = state.Split(' ');
            X = int.Parse(coordinates[0]);
            Y = int.Parse(coordinates[1]);
            Direction = coordinates[2];
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }

        public void Control(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'M')
                {
                    switch (Direction)
                    {
                        case "N":
                            Y++;
                            break;
                        case "E":
                            X ++;
                            break;
                        case "W":
                            X --;
                            break;
                        case "S":
                            Y -- ;
                            break;
                    }
                }
                else if (command == 'R')
                {
                    Direction = Direction switch
                    {
                        "N" => "E",
                        "E" => "S",
                        "S" => "W",
                        "W" => "N",
                        _ => Direction
                    };
                }
                else if (command == 'L')
                {
                    Direction = Direction switch
                    {
                        "N" => "W",
                        "E" => "N",
                        "S" => "E",
                        "W" => "S",
                        _ => Direction
                    };
                }
            }
 
        }
    }
}
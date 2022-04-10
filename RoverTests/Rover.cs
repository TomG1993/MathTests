using System;
using System.Collections.Generic;
using System.Linq;

namespace RoverTests
{
    public class Direction
    {
        public string current { get; set; }
        public string rightTurn { get; set; }
        public string leftTurn { get; set; }
    }
    public class Rover
    {
        private Direction direction;
        private int xAxis;
        private int yAxis;

        List<Direction> directions = new List<Direction>()
            {
                new Direction()
            {
                current = "N",
                rightTurn = "E",
                leftTurn = "W",
            },
                new Direction()
            {
                current = "E",
                rightTurn = "S",
                leftTurn = "N",
            },
                new Direction()
            {
                current = "S",
                rightTurn = "W",
                leftTurn = "E",
            },
                new Direction()
            {
                current = "W",
                rightTurn = "N",
                leftTurn = "S",
            }
        };

        public Rover()
        {
            direction = new Direction()
            {
                current = "N",
                rightTurn = "E",
                leftTurn = "W",
            };
            xAxis = 0;
            yAxis = 0;
        }


        public string Execute(string commands)
        {

            foreach (char c in commands.ToCharArray())
            {
                if (c == 'R')
                {
                    direction = rotateRight();
                }
                else if (c == 'L')
                {
                    direction = rotateLeft();
                }
                else if (c == 'M')
                {
                    if (direction.current == "N")
                    {
                        yAxis++;
                    }
                    if (direction.current == "S")
                    {
                        yAxis--;
                    }
                    if (direction.current == "E")
                        xAxis++;

                    if (direction.current == "W")
                    {
                        xAxis--;
                    }
                }

            }

            return xAxis + ":" + yAxis + ":" + direction.current;
        }

        private int moveXAxis()
        {
            return xAxis + 1;
        }

        private int moveYAxis()
        {
            return yAxis + 1;
        }

        private Direction rotateLeft()
        {
            var currentDirection = directions.FirstOrDefault(x => x.current == direction.current);
            if (currentDirection != null)
            {
                return directions.FirstOrDefault(x => x.current == currentDirection.leftTurn);
            }
            // TODO: throw;
            return null;
        }

        private Direction rotateRight()
        {
            var currentDirection = directions.FirstOrDefault(x => x.current == direction.current);
            if (currentDirection != null)
            {
                return directions.FirstOrDefault(x => x.current == currentDirection.rightTurn);
            }
            // TODO: throw;
            return null;
        }
    }
}
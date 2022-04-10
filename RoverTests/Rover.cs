using System;
using System.Collections.Generic;
using System.Linq;

namespace RoverTests
{
    public class Direction
    {
        public string current;
        public string rightTurn;
        public string leftTurn;
        public string right()
        {
            return rightTurn;
        }

        public string left()
        {
            return leftTurn;
        }
    }
    public class Rover
    {
        private string direction;
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
            direction = "N";
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
                    if (direction == "N")
                    {
                        yAxis++;
                    }
                    if (direction == "S")
                    {
                        yAxis--;
                    }
                    if (direction == "E")
                        xAxis++;

                    if (direction == "W")
                    {
                        xAxis--;
                    }
                }

            }

            return xAxis + ":" + yAxis + ":" + direction;
        }

        private int moveXAxis()
        {
            return xAxis + 1;
        }

        private int moveYAxis()
        {
            return yAxis + 1;
        }

        private string rotateLeft()
        {
            var currentDirection = directions.FirstOrDefault(x => x.current == direction);
            if (currentDirection != null)
            {
                return currentDirection.leftTurn;
            }
            // TODO: throw;
            return "";
        }

        private string rotateRight()
        {
            var currentDirection = directions.FirstOrDefault(x => x.current == direction);
            if (currentDirection != null)
            {
                return currentDirection.rightTurn;
            }
            // TODO: throw;
            return "";
        }
    }
}
using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Compass Direction { get; set; }

        public Coordinate()
        {
            X = 0;
            Y = 0;
            Direction = Compass.N;
        }
        public void leftRotate()
        {
            switch (Direction)
            {
                case Compass.N: Direction = Compass.W;
                    break;
                case Compass.S: Direction = Compass.E;
                    break;
                case Compass.E: Direction = Compass.N;
                    break;
                case Compass.W: Direction = Compass.S;
                    break;
                default:break;
            }
        }

        public void rightRotate()
        {
            switch (Direction)
            {
                case Compass.N: Direction = Compass.E;
                    break;
                case Compass.S: Direction = Compass.W;
                    break;
                case Compass.E: Direction = Compass.S;
                    break;
                case Compass.W: Direction = Compass.N;
                    break;
                default: break;
            }
        }

        public void ChangeCoordiates()
        {
            switch (Direction)
            {
                case Compass.N: Y += 1;
                    break;
                case Compass.S: Y -= 1;
                    break;
                case Compass.E: X += 1;
                    break;
                case Compass.W: X -= 1;
                    break;
                default:
                    throw new Exception($"you entered wrong character in coordinates");
                    break;
            }
        }

        public void Move(string moves,List<int> plateauCoordinates)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'L':
                        leftRotate();
                        break;
                    case 'R':
                        rightRotate();
                        break;
                    case 'M':
                        ChangeCoordiates();
                        break;
                    default:
                        throw new Exception($"You entered wrong character in directions!");  
                        break;
                }
            }
            if (X < 0 || X > plateauCoordinates[0] || Y < 0 || Y > plateauCoordinates[1])
            {
                throw new Exception($"Position ({X},{Y}) is outside the plateau! Position can not be beyond bounderies (0 , 0) and ({plateauCoordinates[0]} , {plateauCoordinates[1]})");
            }
            else
            {
                Console.WriteLine("\nRover is here now\n" + X + " " + Y + " " + Direction+"\n");
            }
        }
    }
}

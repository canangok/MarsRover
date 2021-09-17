using MarsRover.Test.Poco;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Test.Theory
{
    public class MoveTestTheoryData : TheoryData<MoveTestParamater>
    {
        public MoveTestTheoryData()
        {
            Add(new MoveTestParamater
            {
                PlateauCoordinate = new List<int>() { 5, 5 },
                Coordinate = new Coordinate { X = 1, Y = 2, Direction = Compass.N },
                Moves = "LMLMLMLMM",
                Expected = "1 3 N"
            });

            Add(new MoveTestParamater
            {
                PlateauCoordinate = new List<int>() { 5, 5 },
                Coordinate = new Coordinate { X = 3, Y = 3, Direction = Compass.E },
                Moves = "MMRMMRMRRM",
                Expected = "5 1 E"
            });

            //Wrong character in direction
            Add(new MoveTestParamater
            {
                PlateauCoordinate = new List<int>() { 5, 5 },
                Coordinate = new Coordinate { X = 3, Y = 3, Direction = Compass.E },
                Moves = "MMRMMRMRMRRT",
                Expected = "5 1 E"
            });

  
        }
    }
}

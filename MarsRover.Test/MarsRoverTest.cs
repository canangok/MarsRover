using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MarsRover;
using MarsRover.Test.Poco;
using MarsRover.Test.Theory;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
         
        [Theory, ClassData(typeof(MoveTestTheoryData))]
        public void MoveTest_ShouldAssertsTrue_WhenDirectionAndCoordinateAreTrue(MoveTestParamater paramater)
        {
            List<int> plateauCoordinates = paramater.PlateauCoordinate;
            Coordinate coordinate = paramater.Coordinate;
           
            coordinate.MoveInDirection(paramater.Moves, plateauCoordinates);
            var actualOutput = $"{coordinate.X} {coordinate.Y} {coordinate.Direction.ToString()}";
            Assert.Equal(paramater.Expected,actualOutput);
        }

    }
}

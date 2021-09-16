using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MarsRover;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData("LMLMLMLMM", "1 3 N")]
        public void MoveTest_12N_55(string moves, string expected)
        {
            List<int> plateauCoordinates = new List<int> { 5, 5 };
            Coordinate coordinate = new Coordinate()
            {
                X = 1,
                Y = 2,
                Direction = Compass.N
            };
           
            coordinate.Move(moves, plateauCoordinates);
            var actualOutput = $"{coordinate.X} {coordinate.Y} {coordinate.Direction.ToString()}";
            Assert.Equal(expected,actualOutput);
        }

        [Theory]
        [InlineData("MMRMMRMRRM", "5 1 E")]
        public void MoveTest_33E_55(string moves, string expected)
        {
            List<int> plateauCoordinates = new List<int> { 5, 5 };
            Coordinate coordinate = new Coordinate()
            {
                X = 3,
                Y = 3,
                Direction = Compass.E
            };

            coordinate.Move(moves, plateauCoordinates);
            var actualOutput = $"{coordinate.X} {coordinate.Y} {coordinate.Direction.ToString()}";
            Assert.Equal(expected, actualOutput);
        }

        [Theory]
        [InlineData("MMRMMRMRRM", "5 1 E")]
        public void MoveTest_33E_22(string moves, string expected)
        {
            List<int> plateauCoordinates = new List<int> { 2,2};
            Coordinate coordinate = new Coordinate()
            {
                X = 3,
                Y = 3,
                Direction = Compass.E
            };

            coordinate.Move(moves, plateauCoordinates);
            var actualOutput = $"{coordinate.X} {coordinate.Y} {coordinate.Direction.ToString()}";
            Assert.Equal(expected, actualOutput);
        }
    }
}

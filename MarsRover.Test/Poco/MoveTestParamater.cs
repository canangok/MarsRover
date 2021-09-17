using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Test.Poco
{
    public class MoveTestParamater
    {
        public List<int> PlateauCoordinate { get; set; }
        public Coordinate Coordinate { get; set; }
        public string Moves { get; set; }
        public string Expected { get; set; }
    }
}

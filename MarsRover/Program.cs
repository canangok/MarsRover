using System;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the plateau size and coordinates....");
            var plateauCoordinates = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Coordinate coordinate = new Coordinate();

            if (plateauCoordinates.Count == 2)
            {

            }
            if(startPositions.Length == 3)
            {
                coordinate.X = Convert.ToInt32(startPositions[0]);
                coordinate.Y = Convert.ToInt32(startPositions[1]);
                coordinate.Direction = (Compass)Enum.Parse(typeof(Compass), startPositions[2].ToUpper());
            }

            var moves = Console.ReadLine().ToUpper();
            coordinate.Move(moves,plateauCoordinates);

          

            Console.ReadKey();
        }
    }
}

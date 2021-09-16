using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coordinate> rovers = new List<Coordinate>();
            string moves = "";
            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Enter the plateau size and coordinates...And press X for results");

            try
            {
                var plateauCoordinates = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                do
                {
                    var startPositions = Console.ReadLine().Trim().Split(' ');
                    moves = Console.ReadLine().ToUpper();
                    Coordinate coordinate = new Coordinate();

                    coordinate.X = Convert.ToInt32(startPositions[0]);
                    coordinate.Y = Convert.ToInt32(startPositions[1]);
                    coordinate.Direction = (Compass)Enum.Parse(typeof(Compass), startPositions[2].ToUpper());
                    rovers.Add(coordinate);
   
                    consoleKeyInfo = Console.ReadKey(true);
                
                } while (consoleKeyInfo.Key != ConsoleKey.X);

                foreach (var rove in rovers)
                {
                    rove.Move(moves, plateauCoordinates);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

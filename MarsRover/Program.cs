using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Coordinate,string> rovers = new Dictionary<Coordinate,string>();
            string moves = "";
            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Enter the plateau size and coordinates...And press X for results");

            try
            {
                var plateauCoordinate = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                //multiple rovers entries
                do
                {
                    var startPosition = Console.ReadLine().Trim().Split(' ');
                    moves = Console.ReadLine().ToUpper();
                    Coordinate coordinate = new Coordinate();

                    coordinate.X = Convert.ToInt32(startPosition[0]);
                    coordinate.Y = Convert.ToInt32(startPosition[1]);
                    coordinate.Direction = (Compass)Enum.Parse(typeof(Compass), startPosition[2].ToUpper());
                    rovers.Add(coordinate,moves);

                    consoleKeyInfo = Console.ReadKey(true); 
                
                } while (consoleKeyInfo.Key != ConsoleKey.X); 
                
                //output
                foreach (KeyValuePair<Coordinate, string> rove in rovers)
                {
                    rove.Key.MoveInDirection(rove.Value, plateauCoordinate);
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

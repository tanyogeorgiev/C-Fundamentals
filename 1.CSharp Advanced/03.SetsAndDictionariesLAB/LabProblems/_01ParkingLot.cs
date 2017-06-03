using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _01ParkingLot
    {
        public static void Run()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var tokens = Regex.Split(input, "[, ]+", RegexOptions.IgnorePatternWhitespace);
                var operation = tokens[0];
                var carNumber = tokens[1];

                switch (operation)
                {
                    case "IN": parking.Add(carNumber); break;
                    case "OUT": parking.Remove(carNumber); break;
                }

                input = Console.ReadLine();
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

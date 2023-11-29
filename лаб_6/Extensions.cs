using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class Extensions
    {
        public static void BoardPassengers(this Vehicle vehicle, int passengers)
        {
            Console.WriteLine($"{passengers} passengers boarded the {vehicle.GetType().Name}.");
        }

        public static void DisembarkPassengers(this Vehicle vehicle, int passengers)
        {
            Console.WriteLine($"{passengers} passengers disembarked from the {vehicle.GetType().Name}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public string? Color { get; set; }
        public string? SeatColor { get; set; } 

        public void Drive()
        {
            Console.WriteLine($"Building a new {Color} car, with {SeatColor} seats!");
        }
    }
}

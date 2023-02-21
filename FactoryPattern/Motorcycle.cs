using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     public class Motorcycle : IVehicle
    {
        public string? Color { get; set; }  
        public string? HelmetColor { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Building a new {Color} motorcycle with a {HelmetColor} helmet!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "4":
                    return new Car() { Color = "blue" , SeatColor = "Green" };
                case "2":
                    return new Motorcycle() { Color = "red", HelmetColor = "Yellow" };
                default:
                    return new Car();

            }
        }
    }
}

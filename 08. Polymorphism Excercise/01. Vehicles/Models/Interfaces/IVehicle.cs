using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double Fuel { get; }
        double Consumption { get; }

        string Travel(double distance);
        void Refuel(double liters);
    }
}

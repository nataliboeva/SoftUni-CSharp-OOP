using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : BaseVehicle
    {
        public Car(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override double Consumption => base.Consumption + 0.9;
    }
}

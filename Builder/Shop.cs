using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Shop
    {
        public void Construct(VehicleBuilder p_vehicleBuilder)
        {
            p_vehicleBuilder.BuildFrame();
            p_vehicleBuilder.BuildEngine();
            p_vehicleBuilder.BuildWheels();
            p_vehicleBuilder.BuildDoors();
        }
    }
}

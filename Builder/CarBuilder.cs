using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            m_vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            m_vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            m_vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            m_vehicle["frame"] = "Car Frame"; 
        }

        public override void BuildWheels()
        {
            m_vehicle["wheels"] = "4";
        }
    }
}

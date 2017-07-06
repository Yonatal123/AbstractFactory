using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            m_vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            m_vehicle["doors"] = "0"; 
        }

        public override void BuildEngine()
        {
            m_vehicle["engine"] = "50 cc";
        }

        public override void BuildFrame()
        {
            m_vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            m_vehicle["wheels"] = "2";
        }
    }
}

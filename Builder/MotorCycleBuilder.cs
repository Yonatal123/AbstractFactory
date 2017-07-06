using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            m_vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildDoors()
        {
            m_vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            m_vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            m_vehicle["frame"] = "MotorCycleFrame";
        }

        public override void BuildWheels()
        {
            m_vehicle["wheels"] = "2";
        }
    }
}

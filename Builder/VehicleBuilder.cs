using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle
        {
            get { return m_vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

        protected Vehicle m_vehicle;
    }
}

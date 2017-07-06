using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vehicle
    {
        public Vehicle(string p_vehicleType)
        {
            m_vehicleType = p_vehicleType;
        }

        public string this[string p_key]
        {
            get { return m_parts[p_key]; }
            set { m_parts[p_key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", m_vehicleType);
            Console.WriteLine(" Frame : {0}", m_parts["frame"]);
            Console.WriteLine(" Engine : {0}", m_parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", m_parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", m_parts["doors"]);
        }

        private string m_vehicleType;
        private Dictionary<string, string> m_parts = new Dictionary<string, string>();
    }
}

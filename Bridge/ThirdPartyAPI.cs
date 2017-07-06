using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ThirdPartyAPI : IBridgeComponengts
    {
        public void Send(string p_messageType)
        {
            Console.WriteLine("Sending " + p_messageType + " using Third Party API.");
        }
    }
}

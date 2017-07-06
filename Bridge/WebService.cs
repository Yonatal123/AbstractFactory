using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class WebService : IBridgeComponengts
    {
        public void Send(string p_messageType)
        {
            Console.WriteLine("Sending " + p_messageType + " using Webservice.");
        }
    }
}

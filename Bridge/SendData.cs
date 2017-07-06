using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class SendData
    {
        public abstract void Send();
        public IBridgeComponengts BridgeComponents;
    }
}

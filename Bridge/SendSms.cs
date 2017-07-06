using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SendSMS : SendData
    {
        public override void Send()
        {
            BridgeComponents.Send("SMS");
        }
    }
}

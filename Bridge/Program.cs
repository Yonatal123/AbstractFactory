using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SendData sendData = new SendEmail();
            sendData.BridgeComponents = new WebService();
            sendData.Send();

            sendData.BridgeComponents = new ThirdPartyAPI();
            sendData.Send();

            sendData = new SendSMS();

            sendData.BridgeComponents = new WebService();
            sendData.Send();

            sendData.BridgeComponents = new ThirdPartyAPI();
            sendData.Send();

            Console.ReadLine();

        }
    }
}

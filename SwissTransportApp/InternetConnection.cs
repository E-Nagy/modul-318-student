using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;

namespace SwissTransportApp
{
    internal class InternetConnection
    {
        public bool CheckConnectionWifi()
        {
            string googleHost = "142.250.184.46";
            int result = 1;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(googleHost, 2000);
                if (reply.Status == IPStatus.DestinationHostUnreachable)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }


    }
}

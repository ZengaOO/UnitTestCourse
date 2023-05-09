using ConsoleUtilite.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilite.Ping
{
    public class ConsoleService
    {
        private readonly IDNS _dNS;
        public ConsoleService(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string SendPing() 
        {
            //SearchDNS();
            //BuildPacket();
            var dnsSusses = _dNS.SendDNS();//dns true
            if (dnsSusses)
            {
                return "Success: Ping Send";
            }
            else
            {
                return "Failed: Ping not send";
            }
            //return "Success: Ping Send";
        }

        public int PingTimequit(int a, int b)
        {
            return a+b;
        }
         
        public DateTime LastPingDate() 
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions() 
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1 
            };
        }
        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                 new PingOptions()
                 {
                    //object
                    DontFragment = true,
                    Ttl = 1
                 },
                  new PingOptions()
                  {
                    //object
                    DontFragment = true,
                    Ttl = 1
                  },
                   new PingOptions()
                   {
                    //object
                    DontFragment = true,
                    Ttl = 1
                   },
            };
            return pingOptions;
        }
    }
}

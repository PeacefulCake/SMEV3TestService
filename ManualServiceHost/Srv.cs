using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ManualServiceHost
{
    //[ServiceBehavior(Htt)]
    class Srv : ISrv
    {
        public int Make()
        {
            return 15;
        }
    }
}

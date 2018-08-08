using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ManualServiceHost
{
    [ServiceContract]
    interface ISrv
    {
        [OperationContract]
        int Make();
    }
}

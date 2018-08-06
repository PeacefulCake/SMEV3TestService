using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMEV3TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Simple" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Simple.svc or Simple.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace = "urn:FAA.SimpleService", Name = "ServiceBehaviorName", ConfigurationName = "ServiceBehaviorConfigurationName")]
    public class Simple : ISimple
    {
        public SimpleOutputMessage DoWork(SimpleInputMessage input)
        {
            return new SimpleOutputMessage() { Value = 12 };
        }
    }
}

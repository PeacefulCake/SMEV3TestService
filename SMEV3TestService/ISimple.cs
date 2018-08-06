using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMEV3TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISimple" in both code and config file together.
    [ServiceContract(Namespace = "urn:FAA.SimpleService", Name = "ServiceContractName", ConfigurationName = "ServiceContractConfigurationName")]
    public interface ISimple
    {                                                           // Залетает как SOAPAction
        [OperationContract(Name = "OperationContractName", Action = "OperationContractAction", ReplyAction = "OperationContractReplyAction")]
        SimpleOutputMessage DoWork(SimpleInputMessage input);
    }

    [MessageContract(WrapperName = "MessageContractRequestWrapperName", WrapperNamespace = "urn:FAA.SimpleService/messages", IsWrapped = true)]
    public class SimpleInputMessage
    {

    }

    [MessageContract(WrapperName = "MessageContractResponseWrapperName", WrapperNamespace = "urn:FAA.SimpleService/messages", IsWrapped = true)]
    public class SimpleOutputMessage
    {
        [MessageBodyMember(Namespace = "urn:FAA.SimpleService/types")]
        public int Value;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SMEV3TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISMEV3Simple" in both code and config file together.
    [ServiceContract(Namespace = SMEV3Const.ServiceNamespace, ConfigurationName = "CN_ISMEV3Simple", Name = "ISMEV3SimpleService")]
    public interface ISMEV3Simple
    {
        [OperationContract(Action = "urn:SendRequest", ReplyAction = "urn:SendRequestResponse")]
        SendRequestResponseMsg SendRequest(SendRequestRequestMsg request);

        [OperationContract(Action = "urn:GetRequest", ReplyAction = "urn:GetRequestResponse")]
        GetRequestResponseMsg GetRequest(GetRequestRequestMsg request);
    }
    /*
  <DataMember(IsRequired:=True)> _
  <XmlAnyElement("AppData")> _
  Public AppData As XmlElement
     */

    [MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = SMEV3Const.TypesNamespace, IsWrapped = true)]
    public class SendRequestRequestMsg
    {
        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 0)]
        public string SenderProvidedRequestData;
    }

    [MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = SMEV3Const.TypesNamespace, IsWrapped = true)]
    public class SendRequestResponseMsg
    {
        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 0)]
        public string MessageMetadata;
    }

    //[MessageContract(WrapperName = "GetRequestRequest", WrapperNamespace = SMEV3Const.TypesNamespace)]
    [MessageContract(IsWrapped = false)]
    public class GetRequestRequestMsg
    {
        //[DataMember(IsRequired = true)]
        //[XmlAnyElement(Name = "GetRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        [MessageBodyMember(Name = "GetRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestRequest;
    }

    //[MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = SMEV3Const.TypesNamespace)]
    [MessageContract(IsWrapped = false)]
    public class GetRequestResponseMsg
    {
        //[XmlAnyElement(Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        [MessageBodyMember(Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestResponse;
    }
}

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
    [XmlSerializerFormat]
    public interface ISMEV3Simple
    {
        [OperationContract(Action = "urn:SendRequest", ReplyAction = "urn:SendRequestResponse")]
        [XmlSerializerFormat]
        SendRequestResponseMsg SendRequest(SendRequestRequestMsg request);

        [OperationContract(Action = "urn:GetRequest", ReplyAction = "urn:GetRequestResponse")]
        [XmlSerializerFormat]
        GetRequestResponseMsg GetRequest(GetRequestRequestMsg request);
    }


    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class SendRequestRequestMsg
    {
        [DataMember(IsRequired = true)]
        [MessageBodyMember]
        [XmlAnyElement(Name = "SendRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestRequest;
    }

    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class SendRequestResponseMsg
    {
        [DataMember(IsRequired = true)]
        [MessageBodyMember]
        [XmlAnyElement(Name = "SendRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestResponse;
    }



    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class GetRequestRequestMsg
    {
        [DataMember(IsRequired = true)]
        [MessageBodyMember]
        [XmlAnyElement(Name = "GetRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestRequest;
    }

    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class GetRequestResponseMsg
    {
        [DataMember(IsRequired = true)]
        [MessageBodyMember]
        [XmlAnyElement(Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestResponse;
    }
}



/*
[MessageContract(WrapperName = "SendRequestRequest", WrapperNamespace = SMEV3Const.TypesNamespace, IsWrapped = true)]
    public class SendRequestRequestMsg
    {
        [MessageBodyMember(Order = 0)]
        [XmlElement(ElementName = "SenderProvidedRequestData", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement SenderProvidedRequestData;

        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 1)]
        public XmlElement MessageMetadata;
    }

    [MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = SMEV3Const.TypesNamespace, IsWrapped = true)]
    public class SendRequestResponseMsg
    {
        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 0)]
        public XmlElement SenderProvidedRequestData;

        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 1)]
        public XmlElement MessageMetadata;
    }
    * 
 MessageContract(WrapperName = "SendRequestResponse", WrapperNamespace = SMEV3Const.TypesNamespace, IsWrapped = true)]
    public class SendRequestResponseMsg
    {
        [MessageBodyMember(Namespace = SMEV3Const.TypesNamespace, Order = 0)]
        public string MessageMetadata;
    }

    //[MessageContract(WrapperName = "GetRequestRequest", WrapperNamespace = SMEV3Const.TypesNamespace)]
    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class GetRequestRequestMsg
    {
        [DataMember(IsRequired = true)]
        [MessageBodyMember]
        [XmlAnyElement(Name = "GetRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        //[MessageBodyMember(Name = "GetRequestRequest", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestRequest;
    }

    //[MessageContract(WrapperName = "GetRequestResponse", WrapperNamespace = SMEV3Const.TypesNamespace)]
    [MessageContract(IsWrapped = false)]
    [XmlRoot]
    public class GetRequestResponseMsg
    {
        [DataMember]
        [MessageBodyMember]
        [XmlAnyElement(Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        //[MessageBodyMember(Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace)]
        public XmlElement GetRequestResponse;
    }
     */

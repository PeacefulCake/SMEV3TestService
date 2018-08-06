using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SMEV3TestService
{
    using System.Runtime.Serialization;
    using System.Xml;

    [DataContract(Name="Void", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    [KnownType(typeof(SmevFault))]
    public partial class Void : object, IExtensibleDataObject
    {
        
        private ExtensionDataObject extensionDataField;
        
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
    
    [DataContract(Name="SmevFault", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class SmevFault : Void
    {
        
        private string CodeField;
        
        private string DescriptionField;
        
        [DataMember(EmitDefaultValue=false)]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [DataMember(EmitDefaultValue=false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
        
    [ServiceContract(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2", ConfigurationName="SMEVMessageExchangePortType")]
    public interface SMEVMessageExchangePortType
    {
        
        [OperationContract(Action="urn:SendRequest", ReplyAction="*")]
        [FaultContract(typeof(SmevFault), Action="urn:SendRequest", Name="TransactionCodeInvalid", Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.2")]
        [XmlSerializerFormat()]
        SendRequestResponse SendRequest(SendRequestRequest request);
        
        [OperationContract(Action="urn:SendResponse", ReplyAction="*")]
        [XmlSerializerFormat()]
        SendResponseResponse SendResponse(SendResponseRequest request);
        
        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2) сообщения GetStatusRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2).
        [OperationContract(Action="urn:GetStatus", ReplyAction="*")]
        [XmlSerializerFormat()]
        GetStatusResponse GetStatus(GetStatusRequest request);
        
        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2) сообщения GetRequestRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2).
        [OperationContract(Action="urn:GetRequest", ReplyAction="*")]
        [XmlSerializerFormat()]
        GetRequestResponse GetRequest(GetRequestRequest request);
                
        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2) сообщения GetResponseRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2).
        [OperationContract(Action="urn:GetResponse", ReplyAction="*")]
        [XmlSerializerFormat()]
        GetResponseResponse GetResponse(GetResponseRequest request);
        
        // CODEGEN: Контракт генерации сообщений с пространством имен упаковщика (urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2) сообщения AckRequest не соответствует значению по умолчанию (urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2).
        [OperationContract(Action="urn:Ack", ReplyAction="*")]
        [XmlSerializerFormat()]
        AckResponse Ack(AckRequest request);
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedRequestData
    {
        
        private string messageIDField;
        
        private string referenceMessageIDField;
        
        private string transactionCodeField;
        
        private string nodeIDField;
        
        private System.DateTime eOLField;
        
        private bool eOLFieldSpecified;
        
        private System.Xml.XmlElement messagePrimaryContentField;
        
        private System.Xml.XmlElement personalSignatureField;
        
        private AttachmentHeaderType[] attachmentHeaderListField;
        
        private RefAttachmentHeaderType[] refAttachmentHeaderListField;
        
        private SenderProvidedRequestDataBusinessProcessMetadata businessProcessMetadataField;
        
        private Void testMessageField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string ReferenceMessageID
        {
            get
            {
                return this.referenceMessageIDField;
            }
            set
            {
                this.referenceMessageIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public string NodeID
        {
            get
            {
                return this.nodeIDField;
            }
            set
            {
                this.nodeIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=4)]
        public System.DateTime EOL
        {
            get
            {
                return this.eOLField;
            }
            set
            {
                this.eOLField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore()]
        public bool EOLSpecified
        {
            get
            {
                return this.eOLFieldSpecified;
            }
            set
            {
                this.eOLFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=5)]
        public System.Xml.XmlElement MessagePrimaryContent
        {
            get
            {
                return this.messagePrimaryContentField;
            }
            set
            {
                this.messagePrimaryContentField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=6)]
        public System.Xml.XmlElement PersonalSignature
        {
            get
            {
                return this.personalSignatureField;
            }
            set
            {
                this.personalSignatureField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=7)]
        public AttachmentHeaderType[] AttachmentHeaderList
        {
            get
            {
                return this.attachmentHeaderListField;
            }
            set
            {
                this.attachmentHeaderListField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=8)]
        public RefAttachmentHeaderType[] RefAttachmentHeaderList
        {
            get
            {
                return this.refAttachmentHeaderListField;
            }
            set
            {
                this.refAttachmentHeaderListField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=9)]
        public SenderProvidedRequestDataBusinessProcessMetadata BusinessProcessMetadata
        {
            get
            {
                return this.businessProcessMetadataField;
            }
            set
            {
                this.businessProcessMetadataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=10)]
        public Void TestMessage
        {
            get
            {
                return this.testMessageField;
            }
            set
            {
                this.testMessageField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class AttachmentHeaderList
    {
        
        private AttachmentHeaderType[] attachmentHeaderField;
        
        /// <remarks/>
        [XmlElement("AttachmentHeader", Order=0)]
        public AttachmentHeaderType[] AttachmentHeader
        {
            get
            {
                return this.attachmentHeaderField;
            }
            set
            {
                this.attachmentHeaderField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class AttachmentHeaderType
    {
        
        private string contentIdField;
        
        private string mimeTypeField;
        
        private byte[] signaturePKCS7Field;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string contentId
        {
            get
            {
                return this.contentIdField;
            }
            set
            {
                this.contentIdField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="base64Binary", Order=2)]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class FSAuthInfo
    {
        
        private string uuidField;
        
        private string userNameField;
        
        private string passwordField;
        
        private string fileNameField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class AttachmentContentType
    {
        
        private string idField;
        
        private byte[] contentField;
        
        /// <remarks/>
        [XmlElement(DataType="ID", Order=0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="base64Binary", Order=1)]
        public byte[] Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlInclude(typeof(SmevFault))]
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class Void
    {
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class SmevFault : Void
    {
        
        private string codeField;
        
        private string descriptionField;
        
        /// <remarks/>
        /*[XmlElement(Order=0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }*/
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class RefAttachmentHeaderType
    {
        
        private string uuidField;
        
        private string hashField;
        
        private string mimeTypeField;
        
        private byte[] signaturePKCS7Field;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string uuid
        {
            get
            {
                return this.uuidField;
            }
            set
            {
                this.uuidField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="base64Binary", Order=3)]
        public byte[] SignaturePKCS7
        {
            get
            {
                return this.signaturePKCS7Field;
            }
            set
            {
                this.signaturePKCS7Field = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class RefAttachmentHeaderList
    {
        
        private RefAttachmentHeaderType[] refAttachmentHeaderField;
        
        /// <remarks/>
        [XmlElement("RefAttachmentHeader", Order=0)]
        public RefAttachmentHeaderType[] RefAttachmentHeader
        {
            get
            {
                return this.refAttachmentHeaderField;
            }
            set
            {
                this.refAttachmentHeaderField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedRequestDataBusinessProcessMetadata
    {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [XmlAnyElement(Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class AttachmentContentList
    {
        
        private AttachmentContentType[] attachmentContentField;
        
        /// <remarks/>
        [XmlElement("AttachmentContent", Order=0)]
        public AttachmentContentType[] AttachmentContent
        {
            get
            {
                return this.attachmentContentField;
            }
            set
            {
                this.attachmentContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class MessageMetadata
    {
        
        private string messageIdField;
        
        private MessageTypeType messageTypeField;
        
        private MessageMetadataSender senderField;
        
        private System.DateTime sendingTimestampField;
        
        private MessageMetadataRecipient recipientField;
        
        private System.DateTime deliveryTimestampField;
        
        private bool deliveryTimestampFieldSpecified;
        
        private InteractionStatusType statusField;
        
        private bool statusFieldSpecified;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string MessageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public MessageTypeType MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public MessageMetadataSender Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public System.DateTime SendingTimestamp
        {
            get
            {
                return this.sendingTimestampField;
            }
            set
            {
                this.sendingTimestampField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=4)]
        public MessageMetadataRecipient Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=5)]
        public System.DateTime DeliveryTimestamp
        {
            get
            {
                return this.deliveryTimestampField;
            }
            set
            {
                this.deliveryTimestampField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore()]
        public bool DeliveryTimestampSpecified
        {
            get
            {
                return this.deliveryTimestampFieldSpecified;
            }
            set
            {
                this.deliveryTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=6)]
        public InteractionStatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public enum MessageTypeType
    {
        
        /// <remarks/>
        REQUEST,
        
        /// <remarks/>
        BROADCAST,
        
        /// <remarks/>
        RESPONSE,
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class MessageMetadataSender
    {
        
        private string mnemonicField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Mnemonic
        {
            get
            {
                return this.mnemonicField;
            }
            set
            {
                this.mnemonicField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class MessageMetadataRecipient
    {
        
        private string mnemonicField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Mnemonic
        {
            get
            {
                return this.mnemonicField;
            }
            set
            {
                this.mnemonicField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public enum InteractionStatusType
    {
        
        /// <remarks/>
        doesNotExist,
        
        /// <remarks/>
        requestIsQueued,
        
        /// <remarks/>
        requestIsAcceptedBySmev,
        
        /// <remarks/>
        requestIsRejectedBySmev,
        
        /// <remarks/>
        underProcessing,
        
        /// <remarks/>
        responseIsAcceptedBySmev,
        
        /// <remarks/>
        responseIsRejectedBySmev,
        
        /// <remarks/>
        сancelled,
        
        /// <remarks/>
        messageIsArchived,
        
        /// <remarks/>
        messageIsDelivered,
    }
    
    [MessageContract(WrapperName="SendRequestRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class SendRequestRequest
    {
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public SenderProvidedRequestData SenderProvidedRequestData;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AttachmentContentType[] AttachmentContentList;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=2)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public SendRequestRequest()
        {
        }
        
        public SendRequestRequest(SenderProvidedRequestData SenderProvidedRequestData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.SenderProvidedRequestData = SenderProvidedRequestData;
            this.AttachmentContentList = AttachmentContentList;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
    
    [MessageContract(WrapperName="SendRequestResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class SendRequestResponse
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public MessageMetadata MessageMetadata;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement SMEVSignature;
        
        public SendRequestResponse()
        {
        }
        
        public SendRequestResponse(MessageMetadata MessageMetadata, System.Xml.XmlElement SMEVSignature)
        {
            this.MessageMetadata = MessageMetadata;
            this.SMEVSignature = SMEVSignature;
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedResponseData
    {
        
        private string messageIDField;
        
        private string toField;
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("AsyncProcessingStatus", typeof(AsyncProcessingStatus), Order=2)]
        [XmlElement("PersonalSignature", typeof(System.Xml.XmlElement), Order=2)]
        [XmlElement("RequestRejected", typeof(SenderProvidedResponseDataRequestRejected), Order=2)]
        [XmlElement("RequestStatus", typeof(SenderProvidedResponseDataRequestStatus), Order=2)]
        [XmlElement("AttachmentHeaderList", typeof(AttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=2)]
        [XmlElement("MessagePrimaryContent", typeof(System.Xml.XmlElement), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=2)]
        [XmlElement("RefAttachmentHeaderList", typeof(RefAttachmentHeaderList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=2)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("ItemsElementName", Order=3)]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class AsyncProcessingStatus
    {
        
        private string originalMessageIdField;
        
        private InteractionStatusType statusCategoryField;
        
        private string statusDetailsField;
        
        private SmevFault smevFaultField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string OriginalMessageId
        {
            get
            {
                return this.originalMessageIdField;
            }
            set
            {
                this.originalMessageIdField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public InteractionStatusType StatusCategory
        {
            get
            {
                return this.statusCategoryField;
            }
            set
            {
                this.statusCategoryField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string StatusDetails
        {
            get
            {
                return this.statusDetailsField;
            }
            set
            {
                this.statusDetailsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public SmevFault SmevFault
        {
            get
            {
                return this.smevFaultField;
            }
            set
            {
                this.smevFaultField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedResponseDataRequestRejected
    {
        
        private RejectCode rejectionReasonCodeField;
        
        private string rejectionReasonDescriptionField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public RejectCode RejectionReasonCode
        {
            get
            {
                return this.rejectionReasonCodeField;
            }
            set
            {
                this.rejectionReasonCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string RejectionReasonDescription
        {
            get
            {
                return this.rejectionReasonDescriptionField;
            }
            set
            {
                this.rejectionReasonDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public enum RejectCode
    {
        
        /// <remarks/>
        ACCESS_DENIED,
        
        /// <remarks/>
        NO_DATA,
        
        /// <remarks/>
        UNKNOWN_REQUEST_DESCRIPTION,
        
        /// <remarks/>
        FAILURE,
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedResponseDataRequestStatus
    {
        
        private int statusCodeField;
        
        private SenderProvidedResponseDataRequestStatusStatusParameter[] statusParameterField;
        
        private string statusDescriptionField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public int StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("StatusParameter", Order=1)]
        public SenderProvidedResponseDataRequestStatusStatusParameter[] StatusParameter
        {
            get
            {
                return this.statusParameterField;
            }
            set
            {
                this.statusParameterField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string StatusDescription
        {
            get
            {
                return this.statusDescriptionField;
            }
            set
            {
                this.statusDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SenderProvidedResponseDataRequestStatusStatusParameter
    {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <remarks/>
        AsyncProcessingStatus,
        
        /// <remarks/>
        PersonalSignature,
        
        /// <remarks/>
        RequestRejected,
        
        /// <remarks/>
        RequestStatus,
        
        /// <remarks/>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:Attachmen" +
            "tHeaderList")]
        AttachmentHeaderList,
        
        /// <remarks/>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:MessagePr" +
            "imaryContent")]
        MessagePrimaryContent,
        
        /// <remarks/>
        [XmlEnum("urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2:RefAttach" +
            "mentHeaderList")]
        RefAttachmentHeaderList,
    }
    
    [MessageContract(WrapperName="SendResponseRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class SendResponseRequest
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public SenderProvidedResponseData SenderProvidedResponseData;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=1)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AttachmentContentType[] AttachmentContentList;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=2)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public SendResponseRequest()
        {
        }
        
        public SendResponseRequest(SenderProvidedResponseData SenderProvidedResponseData, AttachmentContentType[] AttachmentContentList, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.SenderProvidedResponseData = SenderProvidedResponseData;
            this.AttachmentContentList = AttachmentContentList;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
    
    [MessageContract(WrapperName="SendResponseResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class SendResponseResponse
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public MessageMetadata MessageMetadata;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement SMEVSignature;
        
        public SendResponseResponse()
        {
        }
        
        public SendResponseResponse(MessageMetadata MessageMetadata, System.Xml.XmlElement SMEVSignature)
        {
            this.MessageMetadata = MessageMetadata;
            this.SMEVSignature = SMEVSignature;
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class Timestamp
    {
        
        private string idField;
        
        private System.DateTime valueField;
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [XmlText()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class SmevAsyncProcessingMessage
    {
        
        private AsyncProcessingStatusData itemField;
        
        private System.Xml.XmlElement sMEVSignatureField;
        
        /// <remarks/>
        [XmlElement("AsyncProcessingStatusData", Order=0)]
        public AsyncProcessingStatusData Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public System.Xml.XmlElement SMEVSignature
        {
            get
            {
                return this.sMEVSignatureField;
            }
            set
            {
                this.sMEVSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class AsyncProcessingStatusData
    {
        
        private AsyncProcessingStatus asyncProcessingStatusField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public AsyncProcessingStatus AsyncProcessingStatus
        {
            get
            {
                return this.asyncProcessingStatusField;
            }
            set
            {
                this.asyncProcessingStatusField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetStatusRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetStatusRequest
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=0)]
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public Timestamp Timestamp;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public GetStatusRequest()
        {
        }
        
        public GetStatusRequest(Timestamp Timestamp, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.Timestamp = Timestamp;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetStatusResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetStatusResponse
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public SmevAsyncProcessingMessage SmevAsyncProcessingMessage;
        
        public GetStatusResponse()
        {
        }
        
        public GetStatusResponse(SmevAsyncProcessingMessage SmevAsyncProcessingMessage)
        {
            this.SmevAsyncProcessingMessage = SmevAsyncProcessingMessage;
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class MessageTypeSelector
    {
        
        private string namespaceURIField;
        
        private string rootElementLocalNameField;
        
        private System.DateTime timestampField;
        
        private string nodeIDField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(DataType="anyURI", Order=0)]
        public string NamespaceURI
        {
            get
            {
                return this.namespaceURIField;
            }
            set
            {
                this.namespaceURIField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="NCName", Order=1)]
        public string RootElementLocalName
        {
            get
            {
                return this.rootElementLocalNameField;
            }
            set
            {
                this.rootElementLocalNameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public string NodeID
        {
            get
            {
                return this.nodeIDField;
            }
            set
            {
                this.nodeIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class GetRequestResponseRequestMessage
    {
        
        private object[] itemsField;
        
        private System.Xml.XmlElement sMEVSignatureField;
        
        /// <remarks/>
        [XmlElement("Request", typeof(Request), Order=0)]
        [XmlElement("AttachmentContentList", typeof(AttachmentContentList), Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public System.Xml.XmlElement SMEVSignature
        {
            get
            {
                return this.sMEVSignatureField;
            }
            set
            {
                this.sMEVSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class Request
    {
        
        private SenderProvidedRequestData senderProvidedRequestDataField;
        
        private MessageMetadata messageMetadataField;
        
        private FSAuthInfo[] fSAttachmentsListField;
        
        private string replyToField;
        
        private System.Xml.XmlElement senderInformationSystemSignatureField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public SenderProvidedRequestData SenderProvidedRequestData
        {
            get
            {
                return this.senderProvidedRequestDataField;
            }
            set
            {
                this.senderProvidedRequestDataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public MessageMetadata MessageMetadata
        {
            get
            {
                return this.messageMetadataField;
            }
            set
            {
                this.messageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [XmlArray(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=2)]
        [XmlArrayItem("FSAttachment", IsNullable=false)]
        public FSAuthInfo[] FSAttachmentsList
        {
            get
            {
                return this.fSAttachmentsListField;
            }
            set
            {
                this.fSAttachmentsListField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public string ReplyTo
        {
            get
            {
                return this.replyToField;
            }
            set
            {
                this.replyToField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=4)]
        public System.Xml.XmlElement SenderInformationSystemSignature
        {
            get
            {
                return this.senderInformationSystemSignatureField;
            }
            set
            {
                this.senderInformationSystemSignatureField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetRequestRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetRequestRequest
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=0)]
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public MessageTypeSelector MessageTypeSelector;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public GetRequestRequest()
        {
        }
        
        public GetRequestRequest(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.MessageTypeSelector = MessageTypeSelector;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetRequestResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetRequestResponse
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        public GetRequestResponseRequestMessage RequestMessage;
        
        public GetRequestResponse()
        {
        }
        
        public GetRequestResponse(GetRequestResponseRequestMessage RequestMessage)
        {
            this.RequestMessage = RequestMessage;
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class GetResponseResponseResponseMessage
    {
        
        private Response responseField;
        
        private AttachmentContentList attachmentContentListField;
        
        private System.Xml.XmlElement sMEVSignatureField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public Response Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=1)]
        public AttachmentContentList AttachmentContentList
        {
            get
            {
                return this.attachmentContentListField;
            }
            set
            {
                this.attachmentContentListField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public System.Xml.XmlElement SMEVSignature
        {
            get
            {
                return this.sMEVSignatureField;
            }
            set
            {
                this.sMEVSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2")]
    public partial class Response
    {
        
        private string originalMessageIdField;
        
        private string originalTransactionCodeField;
        
        private string referenceMessageIDField;
        
        private SenderProvidedResponseData senderProvidedResponseDataField;
        
        private MessageMetadata messageMetadataField;
        
        private FSAuthInfo[] fSAttachmentsListField;
        
        private System.Xml.XmlElement senderInformationSystemSignatureField;
        
        private string idField;
        
        /// <remarks/>
        [XmlElement(Order=0)]
        public string OriginalMessageId
        {
            get
            {
                return this.originalMessageIdField;
            }
            set
            {
                this.originalMessageIdField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=1)]
        public string OriginalTransactionCode
        {
            get
            {
                return this.originalTransactionCodeField;
            }
            set
            {
                this.originalTransactionCodeField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=2)]
        public string ReferenceMessageID
        {
            get
            {
                return this.referenceMessageIDField;
            }
            set
            {
                this.referenceMessageIDField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=3)]
        public SenderProvidedResponseData SenderProvidedResponseData
        {
            get
            {
                return this.senderProvidedResponseDataField;
            }
            set
            {
                this.senderProvidedResponseDataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=4)]
        public MessageMetadata MessageMetadata
        {
            get
            {
                return this.messageMetadataField;
            }
            set
            {
                this.messageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [XmlArray(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=5)]
        [XmlArrayItem("FSAttachment", IsNullable=false)]
        public FSAuthInfo[] FSAttachmentsList
        {
            get
            {
                return this.fSAttachmentsListField;
            }
            set
            {
                this.fSAttachmentsListField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Order=6)]
        public System.Xml.XmlElement SenderInformationSystemSignature
        {
            get
            {
                return this.senderInformationSystemSignatureField;
            }
            set
            {
                this.senderInformationSystemSignatureField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetResponseRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetResponseRequest
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=0)]
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public MessageTypeSelector MessageTypeSelector;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public GetResponseRequest()
        {
        }
        
        public GetResponseRequest(MessageTypeSelector MessageTypeSelector, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.MessageTypeSelector = MessageTypeSelector;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="GetResponseResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class GetResponseResponse
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=0)]
        [XmlElement("ResponseMessage")]
        public GetResponseResponseResponseMessage Item;
        
        public GetResponseResponse()
        {
        }
        
        public GetResponseResponse(GetResponseResponseResponseMessage Item)
        {
            this.Item = Item;
        }
    }
    
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType=true, Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
    public partial class AckTargetMessage
    {
        
        private string idField;
        
        private bool acceptedField;
        
        private bool acceptedFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public bool accepted
        {
            get
            {
                return this.acceptedField;
            }
            set
            {
                this.acceptedField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore()]
        public bool acceptedSpecified
        {
            get
            {
                return this.acceptedFieldSpecified;
            }
            set
            {
                this.acceptedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="AckRequest", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class AckRequest
    {
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2", Order=0)]
        [XmlElement(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.2")]
        public AckTargetMessage AckTargetMessage;
        
        [MessageBodyMember(Namespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", Order=1)]
        public System.Xml.XmlElement CallerInformationSystemSignature;
        
        public AckRequest()
        {
        }
        
        public AckRequest(AckTargetMessage AckTargetMessage, System.Xml.XmlElement CallerInformationSystemSignature)
        {
            this.AckTargetMessage = AckTargetMessage;
            this.CallerInformationSystemSignature = CallerInformationSystemSignature;
        }
    }
    
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName="AckResponse", WrapperNamespace="urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped=true)]
    public partial class AckResponse
    {
        
        public AckResponse()
        {
        }
    }
}

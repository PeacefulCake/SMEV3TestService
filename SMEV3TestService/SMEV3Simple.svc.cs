using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace SMEV3TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SMEV3Simple" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SMEV3Simple.svc or SMEV3Simple.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Name = "SMEV3SimpleService", Namespace = SMEV3Const.ServiceNamespace, ConfigurationName = "CN_SMEV3Simple")]
    public class SMEV3Simple : ISMEV3Simple
    {
        public GetRequestResponseMsg GetRequest(GetRequestRequestMsg request)
        {
            //throw new NotImplementedException();
            string StrResponseAppData = @"<smev:AppData xmlns:smev='uri://smevNS' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:ns3='urn://x-artefacts-it-ru/dob/poltava/inquiry-smev/req-resp/1.1' xsi:type='ns3:AppDataErrorInfoType'><ns3:ErrorInfo><ns3:executionResultCode>11</ns3:executionResultCode><ns3:errorMessage>12</ns3:errorMessage></ns3:ErrorInfo></smev:AppData>";
            XmlDocument XDoc = new XmlDocument();
            XDoc.LoadXml(StrResponseAppData);


            var resp = new GetRequestResponseMsg();
            //resp.GetRequestResponse = XDoc.DocumentElement;
            //resp.GetRequestResponse = new XmlElement[2];
            //resp.GetRequestResponse[0] = request.GetRequestRequest;//  new XmlElement();
            //resp.GetRequestResponse[1] = request.GetRequestRequest;//  new XmlElement();
            resp.GetRequestResponse = request.GetRequestRequest.OwnerDocument.CreateElement("GetRequestResponse", SMEV3Const.TypesNamespace);// Name = "GetRequestResponse", Namespace = SMEV3Const.TypesNamespace

            foreach (var n in request.GetRequestRequest.ChildNodes)
            {
                if (((XmlNode)n).NodeType == XmlNodeType.Element)
                {
                    resp.GetRequestResponse.AppendChild(((XmlNode)n).CloneNode(true));
                }
               
            }

            return resp;

        }

        public SendRequestResponseMsg SendRequest(SendRequestRequestMsg request)
        {
            string StrResponse = @"<ns2:SendRequestResponse xmlns='urn://x-artefacts-smev-gov-ru/services/message-exchange/types/basic/1.1' xmlns:ns2='urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1' xmlns:ns3='urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.1'><ns2:MessageMetadata Id='SIGNED_BY_SMEV'><ns2:MessageType>REQUEST</ns2:MessageType><ns2:Sender><ns2:Mnemonic>OV_2</ns2:Mnemonic><ns2:HumanReadableName>Я_ИС_РОИВ1</ns2:HumanReadableName></ns2:Sender><ns2:SendingTimestamp>2014-10-28T13:01:52.208+04:00</ns2:SendingTimestamp><ns2:Recipient><ns2:Mnemonic>mtfoiv1</ns2:Mnemonic><ns2:HumanReadableName>МТ_ИС_ФОИВ1</ns2:HumanReadableName></ns2:Recipient><ns2:SupplementaryData><ns2:DetectedContentTypeName>МТ_ВС_ФОИВ1</ns2:DetectedContentTypeName></ns2:SupplementaryData><ns2:Status>requestIsQueued</ns2:Status></ns2:MessageMetadata><ns2:SMEVSignature><ds:Signature xmlns:ds='http://www.w3.org/2000/09/xmldsig#'><ds:SignedInfo><ds:CanonicalizationMethod Algorithm='http://www.w3.org/2001/10/xml-exc-c14n#'/><ds:SignatureMethod Algorithm='http://www.w3.org/2001/04/xmldsig-more#gostr34102001-gostr3411'/><ds:Reference URI='#SIGNED_BY_SMEV'><ds:Transforms><ds:Transform Algorithm='http://www.w3.org/2001/10/xml-exc-c14n#'/><ds:Transform Algorithm='urn://smev-gov-ru/xmldsig/transform'/></ds:Transforms><ds:DigestMethod Algorithm='http://www.w3.org/2001/04/xmldsig-more#gostr3411'/><ds:DigestValue>i72pO9i/Iod4ueh/IhjtVCdvWdnXKnxju6f1kCtdBrw=</ds:DigestValue></ds:Reference></ds:SignedInfo><ds:SignatureValue>92oLk2Mrxn7R58Bsp77i3ZsOwlElpX4C8k6Rf/nHAv9710SZVYrsVhM1hOxaUSShuO9WONfUQimCjiZ24fkvXA==</ds:SignatureValue><ds:KeyInfo><ds:X509Data><ds:X509Certificate>MIIBozCCAVKgAwIBAgIFAMWImyYwCAYGKoUDAgIDMDYxGDAWBgNVBAsTD0NsaWVudENvbm5lY3RvcjENMAsGA1UEChMEU01FVjELMAkGA1UEBhMCUlUwHhcNMTQwMjE4MDU1MzU1WhcNMTUwMjE4MDU1MzU1WjA2MRgwFgYDVQQLEw9DbGllbnRDb25uZWN0b3IxDTALBgNVBAoTBFNNRVYxCzAJBgNVBAYTAlJVMGMwHAYGKoUDAgITMBIGByqFAwICJAAGByqFAwICHgEDQwAEQJCa1MMgJZn4H66ixt5crBZ8JGlNILbYQJwZdvlvPnXB/5EiFx+j8x6xhwUR2zJMk3Vv4fh+FyaV0ADzY7SF2GqjRTBDMA4GA1UdDwEB/wQEAwID6DAdBgNVHSUEFjAUBggrBgEFBQcDAgYIKwYBBQUHAwEwEgYDVR0TAQH/BAgwBgEB/wIBBTAIBgYqhQMCAgMDQQBca4YCB+42EH5gHwrsBdbpHhZZ5gzanx57u4CQG26txZn49mR/6XmPkXqAE4gN9JwwpIuG61ZVPTRjpYOAGISK</ds:X509Certificate></ds:X509Data></ds:KeyInfo></ds:Signature></ns2:SMEVSignature></ns2:SendRequestResponse>";
            XmlDocument XDoc = new XmlDocument();
            XDoc.LoadXml(StrResponse);

            return new SendRequestResponseMsg() { GetRequestResponse = XDoc.DocumentElement };
        }
    }
}

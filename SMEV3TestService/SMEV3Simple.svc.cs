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
            string StrResponseAppData = "<smev:AppData xmlns:smev='uri://smevNS' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:ns3='urn://x-artefacts-it-ru/dob/poltava/inquiry-smev/req-resp/1.1' xsi:type='ns3:AppDataErrorInfoType'><ns3:ErrorInfo><ns3:executionResultCode>11</ns3:executionResultCode><ns3:errorMessage>12</ns3:errorMessage></ns3:ErrorInfo></smev:AppData>";
            XmlDocument XDoc = new XmlDocument();
            XDoc.LoadXml(StrResponseAppData);


            var resp = new GetRequestResponseMsg();

            //resp.GetRequestResponse = XDoc.DocumentElement;
            //resp.GetRequestResponse = new XmlElement();

            return resp;
        }

        public SendRequestResponseMsg SendRequest(SendRequestRequestMsg request)
        {
            return new SendRequestResponseMsg() { MessageMetadata = "Типо респонс" };
        }
    }
}

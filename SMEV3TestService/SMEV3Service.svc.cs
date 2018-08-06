using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMEV3TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Name = "SMEV3Service", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2", IncludeExceptionDetailInFaults = true)]
    public class SMEV3Service : SMEVMessageExchangePortType
    {
        public AckResponse Ack(AckRequest request)
        {
            throw new NotImplementedException();
        }

        public GetRequestResponse GetRequest(GetRequestRequest request)
        {
            throw new NotImplementedException();
        }

        public GetResponseResponse GetResponse(GetResponseRequest request)
        {
            throw new NotImplementedException();
        }

        public GetStatusResponse GetStatus(GetStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public SendRequestResponse SendRequest(SendRequestRequest request)
        {
            throw new NotImplementedException();
        }

        public SendResponseResponse SendResponse(SendResponseRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

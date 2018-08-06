using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ServiceModel;

namespace SMEV3TestService
{
    [ServiceBehavior(Name = "SMEV3TestService", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/1.2", IncludeExceptionDetailInFaults = true)]
    public class SMEV3Test : SMEVMessageExchangePortType
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
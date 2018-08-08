using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ManualServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8002/Srv"; // Запускать под админом или с грамотно настроенными правами, иначе винда не даст поставить прослушивание на порт
            //<serviceMetadata httpGetEnabled="true" httpsGetEnabled="true"/>
            BasicHttpBinding binding1 = new BasicHttpBinding();
            //binding1.be
            //TimeSpan modifiedCloseTimeout = new TimeSpan(00, 02, 00);
            //binding1.CloseTimeout = modifiedCloseTimeout;

            using (ServiceHost host = new ServiceHost(typeof(Srv)))
            {
                ServiceMetadataBehavior metad = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (metad == null)
                    metad = new ServiceMetadataBehavior();
                metad.HttpGetEnabled = true;
                metad.HttpGetUrl = new Uri(baseAddress);
                host.Description.Behaviors.Add(metad);

                host.AddServiceEndpoint(typeof(ISrv), binding1, baseAddress);
                host.Open();
                Console.WriteLine("host.State == {0}", host.State);
                Console.ReadLine();
            }

            
        }
    }
}

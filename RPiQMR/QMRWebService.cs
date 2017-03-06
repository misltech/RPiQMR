using RPiQMR.QMRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace RPiQMR
{
    public class QMRWebService
    {
        private BasicHttpBinding binding;
        private EndpointAddress address;
        private qmrserviceSoapClient client;

        public QMRWebService()
        {
            
        }

        public async void SetRoomStatus(int Sensorid, int Roomid, bool occupied)
        {
            try
            {
                binding = new BasicHttpBinding();
                binding.MaxReceivedMessageSize = 20000000;
                binding.Security.Mode = BasicHttpSecurityMode.Transport;
                address = new EndpointAddress("https://qmr.guttman.cuny.edu/qmr/qmrservice.asmx");
                client = new qmrserviceSoapClient(binding, address);

                Task exec = client.ReserveRoomBySensorAsync(Sensorid, Roomid, occupied);
                await exec;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

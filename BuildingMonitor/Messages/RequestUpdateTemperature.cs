using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMonitor.Messages
{
    public sealed class RequestUpdateTemperature
    {
        public long RequestId { get;}
        public double? Temperature { get; set; }
        public RequestUpdateTemperature(long requestId, double temperature)
        {
            RequestId = requestId;
            Temperature = temperature;
        }
    }
}

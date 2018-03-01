using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMonitor.Messages
{
    public sealed class RequestTemperature
    {
        public long RequestId { get; }
        public RequestTemperature(long requestId)
        {
            RequestId = requestId;
        }
    }
}

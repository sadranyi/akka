namespace BuildingMonitor.Messages
{
    public sealed class RespondMetadata
    {
        public long RequestId { get; set; }
        public string FloorId { get; set; }
        public string SensorId { get; set; }

        public RespondMetadata(long requestId, string floorId, string sensorId)
        {
            RequestId = requestId;
            FloorId = floorId;
            SensorId = sensorId;
        }
    }
}

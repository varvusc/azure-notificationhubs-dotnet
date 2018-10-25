using System;

namespace SendPushSample
{
    public class SampleConfiguration
    {
        public string PrimaryConnectionString { get; set; }
        public string HubName { get; set; }
        public string Tag {get; set; }
        public string GcmDeviceId {get; set; }
        public string AppleDeviceId {get; set; }
        public string SendType {get; set; }

        public enum Operation {
            Broadcast, 
            SendByTag,
            SendByDevice
        }
    }
}
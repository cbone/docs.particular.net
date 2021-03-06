using System;

namespace MyMessages
{
    [Serializable]
    public class EventMessage : IMyEvent
    {
        public Guid EventId { get; set; }
        public DateTime? Time { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
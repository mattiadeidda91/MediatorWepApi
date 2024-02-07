using MediatR;

namespace MediatorWepApi.Models
{
    public class EventSubscriptionNotification : INotification
    {
        public Event? Event { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
    }
}

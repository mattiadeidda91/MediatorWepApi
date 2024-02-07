using MediatR;

namespace MediatorWepApi.Models.Requests
{
    public class SubscribeToEventRequest : IRequest<EventSubscriptionNotification>
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
    }
}

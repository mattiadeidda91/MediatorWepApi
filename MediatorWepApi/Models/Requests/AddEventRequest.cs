using MediatR;

namespace MediatorWepApi.Models.Requests
{
    public class AddEventRequest : IRequest<Event>
    {
        public string? Name { get; set; }
        public DateTime Date { get; set; }
    }
}

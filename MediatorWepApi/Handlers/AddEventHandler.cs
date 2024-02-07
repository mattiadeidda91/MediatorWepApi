using AutoMapper;
using MediatorWepApi.Models;
using MediatorWepApi.Models.Requests;
using MediatorWepApi.Repository.Interfaces;
using MediatR;

namespace MediatorWepApi.Handlers
{
    public class AddEventHandler : IRequestHandler<AddEventRequest, Event>
    {
        private readonly IEventRepository eventRepository;
        private readonly IMapper mapper;

        public AddEventHandler(IEventRepository eventRepository, IMapper mapper)
        {
            this.eventRepository = eventRepository;
            this.mapper = mapper;
        }

        public async Task<Event> Handle(AddEventRequest request, CancellationToken cancellationToken)
        {
            var eventRequest = mapper.Map<Event>(request);

            var newEvent = await eventRepository.Insert(eventRequest!);

            return newEvent;
        }
    }
}

using MediatorWepApi.Models;
using MediatorWepApi.Repository.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace MediatorWepApi.Repository
{
    public class EventRepository : IEventRepository
    {
        public Task<Event> GetById(int id)
        {
            var eventDb = new Event
            {
                Id = 1,
                Date = DateTime.UtcNow,
                Name = "Amazing Event"
            };

            return Task.FromResult(eventDb);
        }

        public Task<Event> Insert(Event entity)
        {
            var newEvent = new Event
            {
                Id = 1,
                Name = entity.Name,
                Date = entity.Date
            };

            return Task.FromResult(newEvent);
        }
    }
}

using MediatorWepApi.Models;
using MediatorWepApi.Models.Requests;
using MediatorWepApi.Repository.Interfaces;
using MediatR;

namespace MediatorWepApi.Handlers
{
    public class SubscribeToEventHandler : IRequestHandler<SubscribeToEventRequest, EventSubscriptionNotification>
    {
        private readonly IUserRepository userRepository;
        private readonly IEventRepository eventRepository;

        public SubscribeToEventHandler(IUserRepository userRepository, IEventRepository eventRepository) 
        {
            this.userRepository = userRepository;
            this.eventRepository = eventRepository;
        }

        public async Task<EventSubscriptionNotification> Handle(SubscribeToEventRequest request, CancellationToken cancellationToken)
        {
            //TODO: save user subscription to the event

            //Get User data by UserID
            var user = await userRepository.GetById(request.UserId);

            //Get Event data by EventID
            var eventObj = await eventRepository.GetById(request.EventId);

            var notification = new EventSubscriptionNotification
            {
                Event = eventObj,
                Email = user.Email,
                Phone = user.Phone,
                Message = $"The user {user.Username} with ID {request.UserId} subscribed for the event with ID {request.EventId}."
            };

            return await Task.FromResult(notification);
        }
    }

}

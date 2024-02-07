using MediatorWepApi.Factory;
using MediatorWepApi.Models;
using MediatR;

namespace MediatorWepApi.Handlers
{
    public class SendEmailNotificationHandler : INotificationHandler<EventSubscriptionNotification>
    {
        private readonly INotificationFactory notificationFactory;

        public SendEmailNotificationHandler(INotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        public async Task Handle(EventSubscriptionNotification notification, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(notification);
            ArgumentNullException.ThrowIfNull(notification.Email);
            ArgumentNullException.ThrowIfNull(notification.Event);

            var notificationService = notificationFactory.CreateNotificationSender(notification.Email);

            //Send Email
            await notificationService.SendNotification(notification.Event, notification.Email, notification.Message!);
        }
    }
}

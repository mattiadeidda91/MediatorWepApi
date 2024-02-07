using MediatorWepApi.Factory;
using MediatorWepApi.Models;
using MediatR;

namespace MediatorWepApi.Handlers
{
    public class SendSmsNotificationHandler : INotificationHandler<EventSubscriptionNotification>
    {
        private readonly INotificationFactory notificationFactory;

        public SendSmsNotificationHandler(INotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        public async Task Handle(EventSubscriptionNotification notification, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(notification);
            ArgumentNullException.ThrowIfNull(notification.Phone);
            ArgumentNullException.ThrowIfNull(notification.Event);

            var notificationService = notificationFactory.CreateNotificationSender(notification.Phone);

            //Send SMS
            await notificationService.SendNotification(notification.Event, notification.Phone, notification.Message!);
        }
    }
}

using MediatorWepApi.Services;
using MediatorWepApi.Services.Interfaces;

namespace MediatorWepApi.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        public INotification CreateNotificationSender(string recipient)
        {
            if (recipient.Contains('@'))
                return new EmailService();
            else
                return new SmsService();
        }
    }
}

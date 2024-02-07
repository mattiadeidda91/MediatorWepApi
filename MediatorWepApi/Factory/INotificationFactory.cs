using MediatorWepApi.Models;
using MediatorWepApi.Services.Interfaces;

namespace MediatorWepApi.Factory
{
    public interface INotificationFactory
    {
        INotification CreateNotificationSender(string recipient);
    }
}

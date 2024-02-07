using MediatorWepApi.Models;

namespace MediatorWepApi.Services.Interfaces
{
    public interface INotification
    {
        Task SendNotification(Event eventObj, string recipient, string message);
    }
}

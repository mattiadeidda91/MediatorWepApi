using MediatorWepApi.Models;
using MediatorWepApi.Services.Interfaces;

namespace MediatorWepApi.Services
{
    public class SmsService : INotification
    {
        public Task SendNotification(Event eventObj, string recipient, string message)
        {
            Console.WriteLine($"Send SMS to {recipient} for the event: {eventObj.Name} with message: {message}");

            return Task.CompletedTask;
        }
    }
}

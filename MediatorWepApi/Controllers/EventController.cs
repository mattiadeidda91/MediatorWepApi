using MediatorWepApi.Models;
using MediatorWepApi.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorWepApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IMediator mediator;

        public EventController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Event>> AddEvent(AddEventRequest request)
        {
            var response = await mediator.Send(request);

            return response;
        }

        [HttpPost("subscribe")]
        public async Task<IActionResult> Subscribe(SubscribeToEventRequest request)
        {
            var notificationMessage = await mediator.Send(request);

            await mediator.Publish(notificationMessage);

            return Ok();
        }
    }
}
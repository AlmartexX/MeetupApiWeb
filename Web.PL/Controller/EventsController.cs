using Meetup.BIL.Interface;
using Meetup.BIL.ModellsDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.PL.Controller
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class EventsController : ControllerBase
    {
        private readonly IEventsService _eventsService;
       

        public EventsController(IEventsService service)
        {
            _eventsService = service;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<EventDTO>>> GetEventsAsync()
        {
            var events = await _eventsService.GetEventsAsync();
            return events;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<EventDTO>> GetEventByIdAsync(int id)
        {
            var @event = await _eventsService.GetEventByIdAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return @event;
        }

        
        [HttpPost]
        [Authorize]
        public async Task CreateEventAsync(CreateEventDTO newEvent)
        {
             await _eventsService.CreateEventAsync(newEvent);
           
        }

        [HttpPut]
        [Authorize]
        public async Task UpdateEventAsync(UpdateEventDTO updatedEvent)
        {
             await _eventsService.UpdateEventAsync(updatedEvent);
            
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<int>> DeleteEventAsync(int id)
        {
            var result = await _eventsService.DeleteEventAsync(id);
            if (result == 0)
            {
                return NotFound();
            }
            return result;
        }
    }
}

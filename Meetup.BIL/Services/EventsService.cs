
using AutoMapper;
using Meetup.BIL.Interface;
using Meetup.BIL.ModellsDTO;
using Meetup.DAL.Modells;

namespace Meetup.BIL.Services
{
    public class EventsService : IEventsService
    {
        private readonly IMapper _mapper;
        private readonly IEventsRepository _eventsRepository;

        public EventsService(IMapper mapper, IEventsRepository eventsRepository)
        {
            _mapper = mapper;
            _eventsRepository = eventsRepository;

        }

        public async Task<List<EventDTO>> GetEventsAsync()
        {
            var events = await _eventsRepository.GetEventsAsync();
            return _mapper.Map<List<EventDTO>>(events);   
            
        }

        public async Task<EventDTO> GetEventByIdAsync(int id)
        {
            var @event = await _eventsRepository.GetEventByIdAsync(id);
            return _mapper.Map<EventDTO>(@event);

        }

        public async Task CreateEventAsync(CreateEventDTO newEventDto)
        {
            var newEvent = _mapper.Map<Event>(newEventDto);
            await _eventsRepository.CreateEventAsync(newEvent);

        }

        public async Task UpdateEventAsync(UpdateEventDTO eventDTO)
        {
            var updatedEvent = _mapper.Map<Event>(eventDTO);
            await _eventsRepository.UpdateEventAsync(updatedEvent);   
            
        }

        public async Task<int> DeleteEventAsync(int id)
        {
            return await _eventsRepository.DeleteEventAsync(id);        
            
        }
    }
}

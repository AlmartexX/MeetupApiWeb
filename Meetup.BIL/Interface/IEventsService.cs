
using Meetup.BIL.ModellsDTO;

namespace Meetup.BIL.Interface
{
    public interface IEventsService
    {
        Task<List<EventDTO>> GetEventsAsync();
        Task<EventDTO> GetEventByIdAsync(int id);
        Task CreateEventAsync(CreateEventDTO newEvent);
        Task UpdateEventAsync(UpdateEventDTO eventDTO);
        Task<int> DeleteEventAsync(int id);
    }
}

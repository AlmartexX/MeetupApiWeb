

using Meetup.DAL.Modells;

namespace Meetup.BIL.Interface
{
    public interface IEventsRepository
    {
        Task<List<Event>> GetEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task CreateEventAsync(Event eventModel);
        Task UpdateEventAsync(Event eventModel);
        Task<int> DeleteEventAsync(int id);
    }
}

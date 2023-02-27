using Meetup.BIL.Interface;
using Meetup.DAL.Context;
using Meetup.DAL.Interfaces;
using Meetup.DAL.Modells;
using Microsoft.EntityFrameworkCore;


namespace Meetup.BIL.Repository
{
    public class EventsRepository : IEventsRepository
    {
        private readonly IEventContext _context;
        

        public EventsRepository(EventsContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }

       
        public async Task CreateEventAsync(Event newEvent)
        {
        
            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();
           
        }

        public async Task UpdateEventAsync(Event updatedEvent)
        {
            _context.Events.Update(updatedEvent);
            await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteEventAsync(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            _context.Events.Remove(eventToDelete);
            return await _context.SaveChangesAsync();
        }
    }

}

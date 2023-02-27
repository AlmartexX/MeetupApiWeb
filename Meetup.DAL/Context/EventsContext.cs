
using Meetup.DAL.Interfaces;
using Meetup.DAL.Modells;
using Microsoft.EntityFrameworkCore;

namespace Meetup.DAL.Context
{
    public class EventsContext : DbContext, IEventContext
    {
        public DbSet<Event> Events { get; set; }
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new DbInitializer(builder).Seed();

        }

      


    }
}

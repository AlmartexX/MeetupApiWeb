using Meetup.DAL.Modells;
using Microsoft.EntityFrameworkCore;

namespace Meetup.DAL.Interfaces
{
    public interface IEventContext
    {
        DbSet<Event> Events { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

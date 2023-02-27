using Meetup.DAL.Modells;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetup.DAL.Context
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Event>(a =>
            {
                a.HasData(new Event
                {
                    Id = 1,
                    Title = "MeetUp",
                    Description = "The first meetup of our group",
                    Organizer = "Ivan Ivanov",
                    TimeAndLocation = "12.03.2023 18:00, 10 Pushkin Street, office 101",
                });
                a.HasData(new Event
                {
                    Id = 2,
                    Title = "Webinar",
                    Description = "Monthly meetup for developers",
                    Organizer = "Elena Petrova",
                    TimeAndLocation = "04.25.2023 19:00, Lenin St. 20, conference hall",
                });
                a.HasData(new Event
                {
                    Id = 3,
                    Title = "Workshop",
                    Description = "Introduction to Machine Learning",
                    Organizer = "Alexander Sidorov",
                    TimeAndLocation = "08.05.2023 16:30, Gagarina str. 5, coworking",
                });
            });

            
        }
    }
}

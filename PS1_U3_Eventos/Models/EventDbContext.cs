using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1_U3_Eventos.Models
{
    public class EventDbContext:DbContext
    {
        public EventDbContext() : base("MyConnection")
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
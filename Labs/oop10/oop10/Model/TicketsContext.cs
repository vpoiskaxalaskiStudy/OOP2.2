using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop10
{
    public class TicketsContext : DbContext
    {
        public TicketsContext()
            : base("DbConnection")
        { }

        public DbSet<AirTicket> AirTickets { get; set; }
    }

    public class AirTicket
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Country { get; set; }
        public int Count { get; set; }

        public AirTicket(int id,  string date, string country, int count)
        {
            this.Id = id;
            this.Date = date;
            this.Country = country;
            this.Count = count;
        }

        public AirTicket()
        {

        }
    }
}

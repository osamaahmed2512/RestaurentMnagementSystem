using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfTable { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}

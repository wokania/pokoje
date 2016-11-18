using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pokoje.Models
{
    public class Events
    {
        public Events() { }
        public int EventId { get; set; }
        public string content { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public ICollection<ApplicationUserManager> user { get; set; }
        public ICollection<Rooms> roomId { get; set; }
    }
}
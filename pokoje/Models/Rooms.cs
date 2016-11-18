using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pokoje.Models
{
    public class Rooms
    {
        public Rooms() { }
        public int room_id { get; set; }
        public string roomColor { get; set; }

        public ICollection<Events> Event { get; set; }
    }
}
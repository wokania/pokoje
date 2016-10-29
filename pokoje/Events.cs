namespace pokoje
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Events
    {
        public int id { get; set; }

        [StringLength(250)]
        public string text { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public int? room_id { get; set; }

        public int user_id { get; set; }

        [StringLength(250)]
        public string color { get; set; }

        [StringLength(250)]
        public string textColor { get; set; }

    }
}

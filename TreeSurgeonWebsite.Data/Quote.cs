namespace TreeSurgeonWebsite.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quote
    {
        public int QuoteID { get; set; }

        public string JobArea { get; set; }

        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }

        public string TimeLength { get; set; }

        public string Location { get; set; }

        public string Notes { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }
    }
}

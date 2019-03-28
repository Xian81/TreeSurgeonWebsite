namespace TreeSurgeonWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }

        public string productType { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }
    }
}

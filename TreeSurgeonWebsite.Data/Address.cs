namespace TreeSurgeonWebsite.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Products = new HashSet<Product>();
        }

        public int AddressID { get; set; }

        public string AddressLineOne { get; set; }

        public string AddressLinetwo { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}

namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("child")]
    public partial class child
    {
        [Key]
        [StringLength(10)]
        public string color2 { get; set; }

        [StringLength(10)]
        public string location { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }
    }
}

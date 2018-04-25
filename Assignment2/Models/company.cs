namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("company")]
    public partial class company
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [Key]
        [StringLength(10)]
        public string color { get; set; }
    }
}

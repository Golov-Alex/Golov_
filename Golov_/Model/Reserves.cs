namespace Golov_.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reserves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reserve_id { get; set; }

        public int reader_id { get; set; }

        public int book_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime reserve_date { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public virtual Users Users { get; set; }
    }
}

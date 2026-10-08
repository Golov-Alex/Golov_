namespace Golov_.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fine_id { get; set; }

        public int reader_id { get; set; }

        public decimal amount { get; set; }

        [Required]
        [StringLength(50)]
        public string reason { get; set; }

        [Column(TypeName = "date")]
        public DateTime created_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? paid_date { get; set; }

        public virtual Users Users { get; set; }
    }
}

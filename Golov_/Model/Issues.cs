namespace Golov_.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Issues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int record_id { get; set; }

        public int reader_id { get; set; }

        public int copy_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime issue_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime due_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? return_date { get; set; }

        [Required]
        [StringLength(50)]
        public string fine_paid { get; set; }

        public virtual Copies Copies { get; set; }

        public virtual Users Users { get; set; }
    }
}

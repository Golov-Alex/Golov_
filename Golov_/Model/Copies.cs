namespace Golov_.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Copies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Copies()
        {
            Issues = new HashSet<Issues>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int copy_id { get; set; }

        public int book_id { get; set; }

        [Required]
        [StringLength(50)]
        public string inventory_number { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public virtual Book Book { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issues> Issues { get; set; }
    }
}

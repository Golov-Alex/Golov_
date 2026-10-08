namespace Golov_.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LibrarianLogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int action_id { get; set; }

        public int librarian_id { get; set; }

        [Required]
        public string action { get; set; }

        public int? book_id { get; set; }

        public int? reader_id { get; set; }

        public DateTime action_datetime { get; set; }

        public virtual Book Book { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}

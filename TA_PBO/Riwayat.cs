namespace TA_PBO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Riwayat")]
    public partial class Riwayat
    {
        [Key]
        public DateTime Waktu { get; set; }

        [Required]
        [StringLength(15)]
        public string Unsur { get; set; }
    }
}

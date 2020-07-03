namespace TA_PBO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HistoryModel : DbContext
    {
        public HistoryModel()
            : base("name=History_Model")
        {
        }

        public virtual DbSet<Riwayat> Riwayats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

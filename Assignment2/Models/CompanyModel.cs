namespace Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompanyModel : DbContext
    {
        public CompanyModel()
            : base("name=CompanyConnection")
        {
        }

        public virtual DbSet<child> children { get; set; }
        public virtual DbSet<company> companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<company>()
                .Property(e => e.name)
                .IsUnicode(false);
        }

        internal object OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}

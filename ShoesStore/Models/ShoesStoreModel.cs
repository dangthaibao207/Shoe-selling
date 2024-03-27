using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoesStore.Models
{
    public partial class ShoesStoreModel : DbContext
    {
        public ShoesStoreModel()
            : base("name=ShoesStoreModel1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Shoes> Shoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shoes>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}

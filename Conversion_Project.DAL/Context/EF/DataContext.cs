using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DAL.Context.EF
{
    using Entities;
    using Configurations;
    using Microsoft.EntityFrameworkCore;

    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<DataText> DataText { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DataTextConfiguration());

        }
        public override int SaveChanges()
        {
            var addedAuditedEntities = ChangeTracker.Entries().Where(t0 => t0.State == EntityState.Added).Select(d => d.Entity);
            var date = DateTime.Now;
            foreach (var item in addedAuditedEntities)
            {
                (item as BaseEntity).RecordDate = date;
            }
            return base.SaveChanges();

        }
    }
}

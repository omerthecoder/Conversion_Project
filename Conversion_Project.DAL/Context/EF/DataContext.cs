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
    using System.Threading;

    public class DataContext : DbContext
    {
        DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DataText> DataText { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DataTextConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var addedAuditedEntities = ChangeTracker.Entries().Where(t0 => t0.State == EntityState.Added).Select(d => d.Entity);
            var date = DateTime.Now;
            foreach (var item in addedAuditedEntities)
            {
                (item as BaseEntity).RecordDate = date;
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}

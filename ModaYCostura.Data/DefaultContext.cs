using Microsoft.EntityFrameworkCore;
using ModaYCostura.Model.Models;

namespace ModaYCostura.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() { }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Model.Models.Type> Types { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<JobMaterial> JobMaterials { get; set; }
        public DbSet<JobProperty> JobProperties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JobMaterial>(ba =>
            {
                ba.HasKey("MaterialId", "JobId");
            });
            modelBuilder.Entity<JobProperty>(ba =>
            {
                ba.HasKey("JobId", "PropertyId");
            });
        }

    }
}
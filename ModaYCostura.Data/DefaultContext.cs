using Microsoft.EntityFrameworkCore;
using ModaYCostura.Model.Models;

namespace ModaYCostura.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() { }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Localization> Localization { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Model.Models.Type> Types { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}
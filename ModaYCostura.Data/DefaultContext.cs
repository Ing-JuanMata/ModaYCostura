using Microsoft.EntityFrameworkCore;
using ModaYCostura.Model.Models;

namespace ModaYCostura.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() { }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using OceanApi.Models;

namespace OceanApi
{
    public class APIDbContext : DbContext
    {
        public APIDbContext() { }

        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<Candidat> Candidats { get; set; }
    }
}

using LayerP.Models;
using Microsoft.EntityFrameworkCore;

namespace LayerP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<BusinessLayer.Dtos.ThingDto> Things { get; set; }
    }
}

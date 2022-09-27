using CovidDataDisplay.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidDataDisplay.Data
{
    public class ApplicationDbContext : DbContext
    {
        // In constructor, asking for objects, passing objects to base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<CovidCasesAlbertaDbContext> StatisticsDataTable { get; set; }
    }
}

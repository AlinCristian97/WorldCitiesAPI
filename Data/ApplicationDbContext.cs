using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Data.Models;

namespace WorldCitiesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
         : base(options)
        {
        }

        /// <summary>
        /// The Cities table
        /// </summary>
        public DbSet<City> Cities => Set<City>();

        /// <summary>
        /// The Countries table
        /// </summary>
        public DbSet<Country> Countries => Set<Country>();
    }
}

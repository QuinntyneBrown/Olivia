using TvShowMicroservice.Models;
using System.Data.Entity;

namespace TvShowMicroservice.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "TvShowMicroserviceDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<TvShow> TvShows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}

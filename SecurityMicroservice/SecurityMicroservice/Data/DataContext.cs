using SecurityMicroservice.Models;
using System.Data.Entity;

namespace SecurityMicroservice.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "SecurityMicroserviceDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}

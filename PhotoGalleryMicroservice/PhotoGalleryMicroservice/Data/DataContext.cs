using PhotoGalleryMicroservice.Models;
using System.Data.Entity;

namespace PhotoGalleryMicroservice.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "PhotoGalleryMicroserviceDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}

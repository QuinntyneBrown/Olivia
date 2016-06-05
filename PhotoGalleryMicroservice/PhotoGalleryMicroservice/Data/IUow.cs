using PhotoGalleryMicroservice.Models;

namespace PhotoGalleryMicroservice.Data
{
    public interface IUow
    {
        IRepository<Photo> Photos { get; }
        IRepository<Gallery> Galleries { get; }
        IRepository<PhotoGallery> PhotoGalleries { get; }
        void SaveChanges();
    }
}

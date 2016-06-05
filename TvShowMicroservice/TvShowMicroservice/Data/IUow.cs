using TvShowMicroservice.Models;

namespace TvShowMicroservice.Data
{
    public interface IUow
    {
        IRepository<TvShow> TvShows { get; }
        void SaveChanges();
    }
}

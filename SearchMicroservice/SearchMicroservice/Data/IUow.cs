using SearchMicroservice.Models;

namespace SearchMicroservice.Data
{
    public interface IUow
    {
        IRepository<Search> Searchs { get; }
        void SaveChanges();
    }
}

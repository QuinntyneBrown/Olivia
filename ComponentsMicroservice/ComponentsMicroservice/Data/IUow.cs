using ComponentsMicroservice.Models;

namespace ComponentsMicroservice.Data
{
    public interface IUow
    {
        IRepository<Component> Components { get; }
        void SaveChanges();
    }
}

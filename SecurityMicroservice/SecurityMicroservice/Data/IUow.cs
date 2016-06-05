using SecurityMicroservice.Models;

namespace SecurityMicroservice.Data
{
    public interface IUow
    {
        IRepository<User> Users { get; }
        void SaveChanges();
    }
}

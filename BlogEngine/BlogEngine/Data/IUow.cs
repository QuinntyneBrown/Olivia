using BlogEngine.Models;

namespace BlogEngine.Data
{
    public interface IUow
    {
        IRepository<Blog> Blogs { get; }
        void SaveChanges();
    }
}

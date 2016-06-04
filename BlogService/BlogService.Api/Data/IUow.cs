using BlogService.Api.Models;

namespace BlogService.Api.Data
{
    public interface IUow
    {
        IRepository<Blog> Blogs { get; }
        void SaveChanges();
    }
}

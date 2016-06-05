using BlogEngine.Dtos;
using System.Collections.Generic;

namespace BlogEngine.Services
{
    public interface IService
    {
        BlogAddOrUpdateResponseDto AddOrUpdate(BlogAddOrUpdateRequestDto request);
        ICollection<BlogDto> Get();
        BlogDto GetById(int id);
        dynamic Remove(int id);
    }
}

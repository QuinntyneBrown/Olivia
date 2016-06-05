using SearchMicroservice.Dtos;
using System.Collections.Generic;

namespace SearchMicroservice.Services
{
    public interface IService
    {
        SearchAddOrUpdateResponseDto AddOrUpdate(SearchAddOrUpdateRequestDto request);
        ICollection<SearchDto> Get();
        SearchDto GetById(int id);
        dynamic Remove(int id);
    }
}

using TvShowMicroservice.Dtos;
using System.Collections.Generic;

namespace TvShowMicroservice.Services
{
    public interface IService
    {
        TvShowAddOrUpdateResponseDto AddOrUpdate(TvShowAddOrUpdateRequestDto request);
        ICollection<TvShowDto> Get();
        TvShowDto GetById(int id);
        dynamic Remove(int id);
    }
}

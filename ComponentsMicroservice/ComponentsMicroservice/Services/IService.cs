using ComponentsMicroservice.Dtos;
using System.Collections.Generic;

namespace ComponentsMicroservice.Services
{
    public interface IService
    {
        ComponentAddOrUpdateResponseDto AddOrUpdate(ComponentAddOrUpdateRequestDto request);
        ICollection<ComponentDto> Get();
        ComponentDto GetById(int id);
        dynamic Remove(int id);
    }
}

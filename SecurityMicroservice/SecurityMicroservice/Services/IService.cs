using SecurityMicroservice.Dtos;
using System.Collections.Generic;

namespace SecurityMicroservice.Services
{
    public interface IService
    {
        UserAddOrUpdateResponseDto AddOrUpdate(UserAddOrUpdateRequestDto request);
        ICollection<UserDto> Get();
        UserDto GetById(int id);
        dynamic Remove(int id);
    }
}

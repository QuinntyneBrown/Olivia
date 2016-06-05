using SecurityMicroservice.Models;

namespace SecurityMicroservice.Dtos
{
    public class UserDto
    {
        public UserDto()
        {

        }

        public UserDto(User entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}

using ComponentsMicroservice.Models;

namespace ComponentsMicroservice.Dtos
{
    public class ComponentDto
    {
        public ComponentDto()
        {

        }

        public ComponentDto(Component entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}

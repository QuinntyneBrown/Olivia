using SearchMicroservice.Models;

namespace SearchMicroservice.Dtos
{
    public class SearchDto
    {
        public SearchDto()
        {

        }

        public SearchDto(Search entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}

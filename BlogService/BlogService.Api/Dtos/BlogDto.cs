using BlogService.Api.Models;

namespace BlogService.Api.Dtos
{
    public class BlogDto
    {
        public BlogDto()
        {

        }

        public BlogDto(Blog entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}

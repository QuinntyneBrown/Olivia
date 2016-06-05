using PhotoGalleryMicroservice.Models;

namespace PhotoGalleryMicroservice.Dtos
{
    public class PhotoDto
    {
        public PhotoDto()
        {

        }

        public PhotoDto(Photo entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}

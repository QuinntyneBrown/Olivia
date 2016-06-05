namespace PhotoGalleryMicroservice.Models
{
    public class PhotoGallery
    {
        public PhotoGallery()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PhotoId { get; set; }
        public int? GalleryId { get; set; }
    }
}

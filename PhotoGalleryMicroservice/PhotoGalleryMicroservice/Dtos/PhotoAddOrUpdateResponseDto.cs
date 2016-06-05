using PhotoGalleryMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGalleryMicroservice.Dtos
{
    public class PhotoAddOrUpdateResponseDto: PhotoDto
    {
        public PhotoAddOrUpdateResponseDto(Photo entity)
        :base(entity)
        {

        }
    }
}

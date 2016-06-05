using PhotoGalleryMicroservice.Dtos;
using PhotoGalleryMicroservice.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace PhotoGalleryMicroservice.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class PhotoController : ApiController
    {
        public PhotoController(IPhotoService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(PhotoAddOrUpdateResponseDto))]
        public IHttpActionResult Add(PhotoAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(PhotoAddOrUpdateResponseDto))]
        public IHttpActionResult Update(PhotoAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<PhotoDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(PhotoDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly IPhotoService _service;


    }
}

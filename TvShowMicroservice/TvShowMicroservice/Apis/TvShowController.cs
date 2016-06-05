using TvShowMicroservice.Dtos;
using TvShowMicroservice.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace TvShowMicroservice.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class TvShowController : ApiController
    {
        public TvShowController(IService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(TvShowAddOrUpdateResponseDto))]
        public IHttpActionResult Add(TvShowAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(TvShowAddOrUpdateResponseDto))]
        public IHttpActionResult Update(TvShowAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<TvShowDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(TvShowDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly IService _service;


    }
}

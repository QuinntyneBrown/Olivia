using ComponentsMicroservice.Dtos;
using ComponentsMicroservice.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace ComponentsMicroservice.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class ComponentController : ApiController
    {
        public ComponentController(IService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(ComponentAddOrUpdateResponseDto))]
        public IHttpActionResult Add(ComponentAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(ComponentAddOrUpdateResponseDto))]
        public IHttpActionResult Update(ComponentAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<ComponentDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(ComponentDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly IService _service;


    }
}

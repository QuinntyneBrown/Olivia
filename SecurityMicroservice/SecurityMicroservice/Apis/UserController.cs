using SecurityMicroservice.Dtos;
using SecurityMicroservice.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace SecurityMicroservice.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class UserController : ApiController
    {
        public UserController(IService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(UserAddOrUpdateResponseDto))]
        public IHttpActionResult Add(UserAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(UserAddOrUpdateResponseDto))]
        public IHttpActionResult Update(UserAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<UserDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(UserDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly IService _service;


    }
}

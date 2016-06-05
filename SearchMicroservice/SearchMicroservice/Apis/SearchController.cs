using SearchMicroservice.Dtos;
using SearchMicroservice.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace SearchMicroservice.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class SearchController : ApiController
    {
        public SearchController(IService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(SearchAddOrUpdateResponseDto))]
        public IHttpActionResult Add(SearchAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(SearchAddOrUpdateResponseDto))]
        public IHttpActionResult Update(SearchAddOrUpdateRequestDto dto) { return Ok(_service.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<SearchDto>))]
        public IHttpActionResult Get() { return Ok(_service.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(SearchDto))]
        public IHttpActionResult GetById(int id) { return Ok(_service.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_service.Remove(id)); }

        protected readonly IService _service;


    }
}

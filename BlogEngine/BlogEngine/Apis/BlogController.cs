using BlogEngine.Dtos;
using BlogEngine.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace BlogEngine.Apis
{
    [Authorize]
    [RoutePrefix("api/blog")]
    public class BlogController : ApiController
    {
        public BlogController(IBlogService service)
        {
            _blogService = service;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(BlogAddOrUpdateResponseDto))]
        public IHttpActionResult Add(BlogAddOrUpdateRequestDto dto) { return Ok(_blogService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(BlogAddOrUpdateResponseDto))]
        public IHttpActionResult Update(BlogAddOrUpdateRequestDto dto) { return Ok(_blogService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<BlogDto>))]
        public IHttpActionResult Get() { return Ok(_blogService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(BlogDto))]
        public IHttpActionResult GetById(int id) { return Ok(_blogService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_blogService.Remove(id)); }

        protected readonly IBlogService _blogService;


    }
}

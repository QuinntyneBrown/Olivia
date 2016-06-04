using System;
using System.Collections.Generic;
using BlogService.Api.Dtos;

namespace BlogService.Api.Services
{
    public class BlogService : IBlogService
    {
        public BlogService()
        {

        }

        public BlogAddOrUpdateResponseDto AddOrUpdate(BlogAddOrUpdateRequestDto request)
        {
            throw new NotImplementedException();
        }

        public ICollection<BlogDto> Get()
        {
            throw new NotImplementedException();
        }

        public BlogDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

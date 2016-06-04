using System;
using System.Collections.Generic;
using BlogEngine.Dtos;
using BlogEngine.Data;
using BlogEngine.Models;

namespace BlogEngine.Services
{
    public class BlogService : IBlogService
    {
        public BlogService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Blogs;
            _cache = cacheProvider.GetCache();
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

        protected readonly IUow _uow;
        protected readonly IRepository<Blog> _repository;
        protected readonly ICache _cache;
    }
}

using System;
using System.Collections.Generic;
using BlogEngine.Dtos;
using BlogEngine.Data;
using BlogEngine.Models;
using System.Linq;

namespace BlogEngine.Services
{
    public class Service : IService
    {
        public Service(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Blogs;
            _cache = cacheProvider.GetCache();
        }

        public BlogAddOrUpdateResponseDto AddOrUpdate(BlogAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Blog());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new BlogAddOrUpdateResponseDto(entity);
        }

        public ICollection<BlogDto> Get()
        {
            ICollection<BlogDto> response = new HashSet<BlogDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new BlogDto(entity)); }
            return response;
        }

        public BlogDto GetById(int id)
        {
            return new BlogDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Blog> _repository;
        protected readonly ICache _cache;
    }
}

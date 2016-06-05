using System;
using System.Collections.Generic;
using SearchMicroservice.Dtos;
using SearchMicroservice.Data;
using SearchMicroservice.Models;
using System.Linq;

namespace SearchMicroservice.Services
{
    public class Service : IService
    {
        public Service(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Searchs;
            _cache = cacheProvider.GetCache();
        }

        public SearchAddOrUpdateResponseDto AddOrUpdate(SearchAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Search());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new SearchAddOrUpdateResponseDto(entity);
        }

        public ICollection<SearchDto> Get()
        {
            ICollection<SearchDto> response = new HashSet<SearchDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new SearchDto(entity)); }
            return response;
        }

        public SearchDto GetById(int id)
        {
            return new SearchDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Search> _repository;
        protected readonly ICache _cache;
    }
}

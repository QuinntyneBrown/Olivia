using System;
using System.Collections.Generic;
using TvShowMicroservice.Dtos;
using TvShowMicroservice.Data;
using TvShowMicroservice.Models;
using System.Linq;

namespace TvShowMicroservice.Services
{
    public class Service : IService
    {
        public Service(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.TvShows;
            _cache = cacheProvider.GetCache();
        }

        public TvShowAddOrUpdateResponseDto AddOrUpdate(TvShowAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new TvShow());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new TvShowAddOrUpdateResponseDto(entity);
        }

        public ICollection<TvShowDto> Get()
        {
            ICollection<TvShowDto> response = new HashSet<TvShowDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new TvShowDto(entity)); }
            return response;
        }

        public TvShowDto GetById(int id)
        {
            return new TvShowDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<TvShow> _repository;
        protected readonly ICache _cache;
    }
}

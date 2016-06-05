using System;
using System.Collections.Generic;
using ComponentsMicroservice.Dtos;
using ComponentsMicroservice.Data;
using ComponentsMicroservice.Models;
using System.Linq;

namespace ComponentsMicroservice.Services
{
    public class Service : IService
    {
        public Service(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Components;
            _cache = cacheProvider.GetCache();
        }

        public ComponentAddOrUpdateResponseDto AddOrUpdate(ComponentAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Component());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new ComponentAddOrUpdateResponseDto(entity);
        }

        public ICollection<ComponentDto> Get()
        {
            ICollection<ComponentDto> response = new HashSet<ComponentDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new ComponentDto(entity)); }
            return response;
        }

        public ComponentDto GetById(int id)
        {
            return new ComponentDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Component> _repository;
        protected readonly ICache _cache;
    }
}

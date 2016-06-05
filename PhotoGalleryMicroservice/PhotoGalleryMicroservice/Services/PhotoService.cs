using System;
using System.Collections.Generic;
using PhotoGalleryMicroservice.Dtos;
using PhotoGalleryMicroservice.Data;
using PhotoGalleryMicroservice.Models;
using System.Linq;

namespace PhotoGalleryMicroservice.Services
{
    public class PhotoService : IPhotoService
    {
        public PhotoService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Photos;
            _cache = cacheProvider.GetCache();
        }

        public PhotoAddOrUpdateResponseDto AddOrUpdate(PhotoAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Photo());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new PhotoAddOrUpdateResponseDto(entity);
        }

        public ICollection<PhotoDto> Get()
        {
            ICollection<PhotoDto> response = new HashSet<PhotoDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new PhotoDto(entity)); }
            return response;
        }

        public PhotoDto GetById(int id)
        {
            return new PhotoDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Photo> _repository;
        protected readonly ICache _cache;
    }
}

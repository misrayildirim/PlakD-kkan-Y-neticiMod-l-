using PlakDükkanıYöneticiModülü.Abstract_Repositories;
using PlakDükkanıYöneticiModülü.Abstract_Services;
using PlakDükkanıYöneticiModülü.Data;
using PlakDükkanıYöneticiModülü.Entities;
using PlakDükkanıYöneticiModülü.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Concrete_Service
{
    public class AlbumService:IAlbumService
    {
        private readonly IGenericRepository<Album> _repository;

        public AlbumService(IGenericRepository<Album> repository)
        {
            _repository = repository;
        }

        public void AddAlbum(Album album)
        {
            _repository.Add(album);
        }

        public void DeleteAlbum(int id)
        {
           _repository?.Delete(id);
        }

        public List<Album> GetAlbumsNotOnSale()
        {
            return _repository.GetAll().Where(x => x.IsSale == SaleStatus.NotOnSale).ToList();
        }

        public List<Album> GetAlbumsOnSale()
        {
            return _repository.GetAll().Where(x=>x.IsSale==SaleStatus.OnSale).ToList();
        }

        public List<Album> GetAllAlbums()
        {
            return _repository.GetAll();
        }

        public Album GetByIdAlbum(int id)
        {
            return _repository.GetById(id);
        }

        public List<Album> GetDiscountedAlbums()
        {
            return _repository.GetAll().Where(x=>x.DiscountRace!=null && x.DiscountRace>0).OrderByDescending(x=>x.DiscountRace).ToList();
        }

        public List<Album> GetLastTenAlbums()
        {
            return _repository.GetAll().OrderByDescending(x=>x.CreatedTime).Take(10).ToList();
        }

        public void UpdateAlbum(int id,Album album)
        {
            var entityToUpdate = GetByIdAlbum(id);
            entityToUpdate.CreatedTime = DateTime.Now;
            _repository.Update(entityToUpdate.Id,entityToUpdate);
            
        }
    }
}

using PlakDükkanıYöneticiModülü.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Abstract_Services
{
    public  interface IAlbumService
    {
        void AddAlbum(Album album);
        void UpdateAlbum(int i,Album album);
        void DeleteAlbum(int id);
        List<Album> GetAllAlbums();
        Album GetByIdAlbum(int id);
        List<Album> GetAlbumsNotOnSale();
        List<Album> GetAlbumsOnSale();
        List<Album> GetLastTenAlbums();
        List<Album> GetDiscountedAlbums();
        
    }
}

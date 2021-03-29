using LetMePutSomeAsyncInIt.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetMePutSomeAsyncInIt.Web.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        Task<Album> GetByID(int id);
        Task<List<Album>> GetForUser(int userID);

        Task<List<Album>> GetAll();
    }
}
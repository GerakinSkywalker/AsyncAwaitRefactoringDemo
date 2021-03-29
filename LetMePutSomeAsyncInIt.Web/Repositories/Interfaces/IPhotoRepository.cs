using LetMePutSomeAsyncInIt.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetMePutSomeAsyncInIt.Web.Repositories.Interfaces
{
    public interface IPhotoRepository
    {
        Task<Photo> GetByID(int id);
        Task<List<Photo>> GetAll();
    }
}
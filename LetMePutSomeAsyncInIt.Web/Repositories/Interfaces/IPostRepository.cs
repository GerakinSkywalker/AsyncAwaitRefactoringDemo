using LetMePutSomeAsyncInIt.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetMePutSomeAsyncInIt.Web.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAll();
        Task<Post> GetByID(int id);
        Task<List<Post>> GetForUser(int userID);
    }
}
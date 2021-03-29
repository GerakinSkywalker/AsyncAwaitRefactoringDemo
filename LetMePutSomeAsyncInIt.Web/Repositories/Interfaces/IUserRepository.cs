using LetMePutSomeAsyncInIt.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetMePutSomeAsyncInIt.Web.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> GetByID(int id);
    }
}
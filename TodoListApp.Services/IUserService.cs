#pragma warning disable
using TodoListApp.WebApi.Models;

namespace TodoListApp.Services
{
    public interface IUserService
    {
        User GetById(int id);

        IEnumerable<User> GetAll();

        void Create(User user);

        void Update(User user);

        void Delete(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

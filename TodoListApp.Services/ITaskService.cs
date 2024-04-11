using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Services
{
    public interface ITaskService
    {
        Task GetById(int id);
        IEnumerable<Task> GetAll();
        void Create(Task task);
        void Update(Task task);
        void Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.WebApi.Models;

namespace TodoListApp.Services
{
    public interface ITodoListService
    {
        TodoList GetById(int id);
        IEnumerable<TodoList> GetAll();
        void Create(TodoList todoList);
        void Update(TodoList todoList);
        void Delete(int id);
    }
}

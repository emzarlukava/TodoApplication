using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.WebApi.Models;

namespace TodoListApp.Services
{
    public interface ICommentService
    {
        Comment GetById(int id);
        IEnumerable<Comment> GetAll();
        void Create(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
    }
}

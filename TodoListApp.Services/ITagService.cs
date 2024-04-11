#pragma warning disable
using TodoListApp.WebApi.Models;

namespace TodoListApp.Services
{
    public interface ITagService
    {
        Tag GetById(int id);

        IEnumerable<Tag> GetAll();

        void Create(Tag tag);

        void Update(Tag tag);

        void Delete(int id);
    }
}

#pragma warning disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;

namespace TodoListApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext context;

        public TodoItemsController(TodoContext context)
        {
            this.context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            if (this.context.TodoItems == null)
            {
                return this.NotFound();
            }

            return await this.context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            if (this.context.TodoItems == null)
            {
                return this.NotFound();
            }

            var todoItem = await this.context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return this.NotFound();
            }

            return todoItem;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return this.BadRequest();
            }

            this.context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                _ = await this.context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.TodoItemExists(id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            if (this.context.TodoItems == null)
            {
                return this.Problem("Entity set 'TodoContext.TodoItems'  is null.");
            }

            _ = this.context.TodoItems.Add(todoItem);
            _ = await this.context.SaveChangesAsync();

            return this.CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            if (this.context.TodoItems == null)
            {
                return this.NotFound();
            }

            var todoItem = await this.context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return this.NotFound();
            }

            _ = this.context.TodoItems.Remove(todoItem);
            _ = await this.context.SaveChangesAsync();

            return this.NoContent();
        }

        private bool TodoItemExists(long id)
        {
            return (this.context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

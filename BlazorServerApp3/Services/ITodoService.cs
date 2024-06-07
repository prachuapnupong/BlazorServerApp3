using BlazorServerApp3.Data;

namespace BlazorServerApp3.Services;

public interface ITodoService
{
    public void                  Add(TodoItem todo);
    public IEnumerable<TodoItem> GetAll();
    public void                  Delete(TodoItem todo);
    public void                  Complete(TodoItem item);
    public void                  Uncomplete(TodoItem item);
}
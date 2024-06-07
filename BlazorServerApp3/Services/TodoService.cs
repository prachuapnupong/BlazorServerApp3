using BlazorServerApp3.Data;

namespace BlazorServerApp3.Services;

public class TodoService : ITodoService
{
    readonly IList<TodoItem> _todoItems;

    public TodoService() {
        _todoItems = new List<TodoItem>() {
            new TodoItem("Wash Clothes"),
            new TodoItem("Clean Desk")
        };
    }
    
    public void Add(TodoItem todo) {
        _todoItems.Add(todo);
    }

    public IEnumerable<TodoItem> GetAll() {
        return _todoItems.ToList();
    }

    public void Delete(TodoItem todo) {
        _todoItems.RemoveAt(_todoItems.IndexOf(todo));
    }

    public void Complete(TodoItem item) {
        item.Completed = true;
    }

    public void Uncomplete(TodoItem item) {
        item.Completed = false;
    }
}
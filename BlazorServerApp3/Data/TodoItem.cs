namespace BlazorServerApp3.Data;

public class TodoItem
{
    public TodoItem(string text) {
        Text = text;
    }
    public string Text { get; set; }
    public bool Completed { get; set; }
}
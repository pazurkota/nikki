namespace nikki.Model;

public class Note
{
    public string Text { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
}
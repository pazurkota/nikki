namespace nikki.Model;

public class Note
{
    public string Text { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
    
    public string PreviewText => string.IsNullOrWhiteSpace(Text)
        ? ""
        : Text.Length <= 40 ? Text : Text.Substring(0, 40) + "...";
}
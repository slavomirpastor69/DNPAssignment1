namespace Entities;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int PostId { get; set; }
    public int AuthorId { get; set; }
}
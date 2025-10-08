using System;

public class Comment
{
    private string Name;
    private string Commenta;

    public Comment(string CommentName, string Commentaa)
    {
        Name = CommentName;
        Commenta = Commentaa;
    }

    public string GetComment()
    {
        return $"{Name}\n, {Commenta}";
    }
}
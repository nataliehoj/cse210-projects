using System;

public class Video
{
    private string VidName;
    private string VidAuthor;
    private int VidLength;
    private List<Comment> vidComments = new List<Comment>();

    public Video(string _VidName, string _VidAuthor, int _VidLength)
    {
        VidName = _VidName;
        VidAuthor = _VidAuthor;
        VidLength = _VidLength;
    }

    public void GetComment(Comment vidCommentaa)
    {
        vidComments.Add(vidCommentaa);
    }

    public string GetVidName()
    {
        return VidName;
    }

    public int GetVidLength()
    {
        return VidLength;
    }

    public string GetVidAuthor()
    {
        return VidAuthor;
    }

    public int GetCommentNum()
    {
        return vidComments.Count;
    }

    public void DisplayAll()
    {
        foreach (Comment comments in vidComments)
        {
            Console.WriteLine($"{comments.GetName()}");
            Console.WriteLine($"{comments.GetComment()}");
        }
    }

}
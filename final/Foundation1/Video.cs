using System.Transactions;

public class Video
{
    // Stores a representation of a YouTube video
    
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void CreateComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public string GetVideoInfo()
    {
        string videoInfo = 
            $"Title: {_title}\n" + 
            $"Creator: {_author}\n" + 
            $"Length (seconds): {_length}\n" +
            $"Number of comments: {_comments.Count}\n";

        foreach (Comment comment in _comments)
        {
            videoInfo += 
                $"User: {comment.GetName()}\n" +
                $"Comment: {comment.GetText()}\n";
        }



        return videoInfo;
    }
}